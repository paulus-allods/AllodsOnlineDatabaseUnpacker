using System;
using System.IO;
using System.Text;
using System.Xml;
using Database;
using Database.Resource;
using NLog;

#if DEBUG
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
            Logger.Info($"Starting unpacker with {objectList.Length} files");
            GameDatabase.Populate(objectList);
#if !DEBUG
            foreach (var obj in objectList) BuildObject(obj);
#else
            Parallel.ForEach(objectList, BuildObject);
#endif
            var notIndexedDependencies = GameDatabase.GetNotIndexedDependencies();
            if (notIndexedDependencies.Length > 0)
            {
                GameDatabase.ResetNotIndexedDependencies();
                // GameDatabase.ResetMissingFiles();
                Run(notIndexedDependencies);
            }
        }

        private void BuildObject(string filePath)
        {
            if (!GameDatabase.DoesFileExists(filePath))
            {
                return; // Some files are indexed but not present in pack.bin, just skipping them
            }
            var className = Utils.GetClassName(filePath);
            var type = Type.GetType($"Database.Resource.Implementation.{className}, Database");
            if (type is null)
            {
                return; // Some types are not extracted because they are not implemented in the unpacker
            }
            if (!(Activator.CreateInstance(type) is Resource obj))
            {
                throw new Exception($"Obj is null for {filePath}");
            }
            obj.Deserialize(GameDatabase.GetObjectPtr(filePath));
            var directoryName = Path.GetDirectoryName(filePath);
            if (directoryName is null)
            {
                throw new Exception($"Directory name is null for path {filePath}");
            }
            directoryName = Path.Combine(exportFolder, directoryName);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            using (var writer = new XmlTextWriter(Path.Combine(exportFolder, filePath), new UTF8Encoding(false)))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                if (testMode)
                {
                    obj.Serialize(className);
                }
                else
                {
                    obj.Serialize(className).Save(writer);
                }
            }
        }
    }
}