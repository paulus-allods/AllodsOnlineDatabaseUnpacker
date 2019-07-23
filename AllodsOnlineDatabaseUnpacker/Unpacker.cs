using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Database;
using Database.DataType.Implementation;
using Database.Resource;
using NLog;

namespace AllodsOnlineDatabaseUnpacker
{
    public class Unpacker
    {        
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly bool _exportMode;
        private readonly string _exportFolder;

        public Unpacker(bool exportMode, string exportFolder)
        {
            _exportMode = exportMode;
            _exportFolder = exportFolder;
        }

        public void Run()
        {
            Logger.Info("Starting unpacker");
            EditorDatabase.InitDataSystem(Paths.DataDir, "");
            EditorDatabase.Populate();
            GameDatabase.InitDataSystem(Paths.DataDir, "");
            var objectList = EditorDatabase.GetObjectList();
            File.WriteAllLines("EditorDatabase.txt", objectList);
            GameDatabase.Populate(objectList);
            var missingList = GameDatabase.GetMissingFiles();
            File.WriteAllLines("missingFiles.txt",missingList);
            Parallel.ForEach(objectList, BuildObject);
        }

        private void BuildObject(string filePath)
        {
            if (!GameDatabase.DoesFileExists(filePath))
            {
                return;
            }
            var className = Utils.GetClassName(filePath);
            var type = Type.GetType($"Database.Resource.Implementation.{className}, Database");
            if (type is null)
            {
                // All object type that are not extracted will go this way
                return;
            }
            if (!(Activator.CreateInstance(type) is Resource obj))
            {
                throw new Exception($"Obj is null for {filePath}");
            }
            obj.Deserialize(GameDatabase.GetObjectPtr(filePath));
            if (_exportMode)
            {
                var directoryName = Path.GetDirectoryName(filePath);
                if (directoryName is null)
                {
                    throw new Exception($"Directory name is null for path {filePath}");
                }
                directoryName = Path.Combine(_exportFolder, directoryName);
                if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);
                using (var writer = new XmlTextWriter(Path.Combine(_exportFolder, filePath), new UTF8Encoding(false)))
                {
                    obj.Serialize(className).Save(writer);
                }
            }
        }
    }
}