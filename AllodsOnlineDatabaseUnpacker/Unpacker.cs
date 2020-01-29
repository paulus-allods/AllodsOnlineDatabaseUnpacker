using System;
using System.IO;
using System.Text;
using System.Xml;
using Database;
using Database.Resource;
using NLog;

#if !DEBUG
using System.Threading.Tasks;
#endif

namespace AllodsOnlineDatabaseUnpacker
{
    public class Unpacker
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly string exportFolder;
        private readonly bool exportMode;

        public Unpacker(bool exportMode, string exportFolder)
        {
            this.exportMode = exportMode;
            this.exportFolder = exportFolder;
        }

        public void Run(string[] objectList)
        {
            Logger.Info("Starting unpacker");
            if (objectList is null)
            {
                EditorDatabase.InitDataSystem(Paths.DataDir, "");
                EditorDatabase.Populate();
                objectList = EditorDatabase.GetObjectList();
                File.WriteAllLines("EditorDatabase.txt", objectList);
            }

            GameDatabase.InitDataSystem(Paths.DataDir, "");
            GameDatabase.Populate(objectList);
            var missingList = GameDatabase.GetMissingFiles();
            File.WriteAllLines("missingFiles.txt", missingList);
#if DEBUG
            foreach (var obj in objectList) BuildObject(obj);
#else
            Parallel.ForEach(objectList, BuildObject);
#endif
        }

        private void BuildObject(string filePath)
        {
            if (!GameDatabase.DoesFileExists(filePath)) return;
            var className = Utils.GetClassName(filePath);
            var type = Type.GetType($"Database.Resource.Implementation.{className}, Database");
            if (type is null) return;
            if (!(Activator.CreateInstance(type) is Resource obj)) throw new Exception($"Obj is null for {filePath}");
            obj.Deserialize(GameDatabase.GetObjectPtr(filePath));
            if (exportMode)
            {
                var directoryName = Path.GetDirectoryName(filePath);
                if (directoryName is null) throw new Exception($"Directory name is null for path {filePath}");
                directoryName = Path.Combine(exportFolder, directoryName);
                if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);
                using (var writer = new XmlTextWriter(Path.Combine(exportFolder, filePath), new UTF8Encoding(false)))
                {
                    obj.Serialize(className).Save(writer);
                }
            }
        }
    }
}