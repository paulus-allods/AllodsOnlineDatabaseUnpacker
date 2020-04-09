using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NLog;

namespace Database
{
    public static class GameDatabase
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static readonly Dictionary<string, IntPtr> ReversedIndex;
        private static readonly List<string> MissingFiles;
        private static HashSet<string> NotIndexedDependencies;

        private static IntPtr databasePtr;
        private static HandleRef databaseHandle;

        static GameDatabase()
        {
            ReversedIndex = new Dictionary<string, IntPtr>();
            MissingFiles = new List<string>();
            NotIndexedDependencies = new HashSet<string>();
        }

        public static void InitDataSystem(string dataPath, string localizationExtension)
        {
            if (Wrapper.InitGameDataSystem(dataPath, localizationExtension, false, false, true, false))
                Logger.Info("Game data system loaded from {0}", dataPath);
            else
                throw new Exception($"Could not load game data system from {dataPath}");
            databasePtr = Wrapper.GetMainDatabase();
            databaseHandle = new HandleRef(new object(), databasePtr);
        }

        public static void Populate(string[] fileNames)
        {
            Logger.Info("Start populating game database with {0} files", fileNames.Length);
            foreach (var file in fileNames)
            {
                var dbid = Wrapper.GetDBIDByName(databaseHandle, file);
                if (!Wrapper.DoesObjectExist(databasePtr, dbid))
                {
                    MissingFiles.Add(file);
                }
                else
                {
                    var ptr = Wrapper.GetObject(databasePtr, dbid);
                    ReversedIndex.Add(file, ptr);
                    Logger.Debug("Object {0} added to database", file);
                }
            }

            var missing = MissingFiles.Count;
            Logger.Info("Game database populated with {0} files, {1} files are missing", fileNames.Length - missing, missing);
        }

        public static bool DoesFileExists(string filename)
        {
            return ReversedIndex.ContainsKey(filename);
        }

        public static IntPtr GetObjectPtr(string filename)
        {
            if (!ReversedIndex.TryGetValue(filename, out var result))
                throw new Exception("Could not find object pointer");
            return result;
        }

        public static void AddNotIndexedDependency(string filename)
        {
            if (!NotIndexedDependencies.Contains(filename))
            {
                NotIndexedDependencies.Add(filename);
            }
        }

        public static string[] GetNotIndexedDependencies()
        {
            return NotIndexedDependencies.ToArray();
        }

        public static void ResetNotIndexedDependencies()
        {
            NotIndexedDependencies.Clear();
        }

        public static string[] GetMissingFiles()
        {
            return MissingFiles.ToArray();
        }

        public static void ResetMissingFiles()
        {
            MissingFiles.Clear();
        }

        public static string[] GetMissingFiles()
        {
            return MissingFiles.ToArray();
        }
    }
}