using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NLog;

namespace Database
{
    public static class GameDatabase
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<IntPtr, string> Index;
        private static readonly Dictionary<string, IntPtr> ReversedIndex;
        private static readonly List<string> MissingFiles;
        private static IntPtr databasePtr;
        private static HandleRef databaseHandle;

        static GameDatabase()
        {
            Index = new Dictionary<IntPtr, string>();
            ReversedIndex = new Dictionary<string, IntPtr>();
            MissingFiles = new List<string>();
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
                    Index.Add(ptr, file);
                    ReversedIndex.Add(file, ptr);
                    //Logger.Debug("Object {0} added to database", file);
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

        public static string GetObjectName(IntPtr ptr)
        {
            if (ptr.ToInt32() == 0) return "";
            if (!Index.TryGetValue(ptr, out var result))
            {
                Logger.Error($"Could not find object name {ptr.ToString("x8")}");
                return "";
            }

            //throw new Exception($"Could not find object name {ptr.ToString("x8")}");
            return result;
        }

        public static string[] GetMissingFiles()
        {
            return MissingFiles.ToArray();
        }
    }
}