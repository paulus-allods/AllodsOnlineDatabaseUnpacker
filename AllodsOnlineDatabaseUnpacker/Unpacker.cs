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
        private readonly bool testMode;

        public Unpacker(bool testMode, string exportFolder)
        {
            this.testMode = testMode;
            this.exportFolder = exportFolder;
        }

        public void Run(string[] objectList)
        {
            Logger.Info("Starting unpacker");
            GameDatabase.Populate(objectList);
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
            if (!testMode)
            {
                var directoryName = Path.GetDirectoryName(filePath);
                if (directoryName is null) throw new Exception($"Directory name is null for path {filePath}");
                directoryName = Path.Combine(exportFolder, directoryName);
                if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);
                using (var writer = new XmlTextWriter(Path.Combine(exportFolder, filePath), new UTF8Encoding(false)))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.Indentation = 4;
                    obj.Serialize(className).Save(writer);
                }
            }
        }
    }
}