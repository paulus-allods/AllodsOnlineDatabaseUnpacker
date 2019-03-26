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
        private static IntPtr _databasePtr;
        private static HandleRef _databaseHandle;

        static GameDatabase()
        {
            Index = new Dictionary<IntPtr, string>();
            ReversedIndex = new Dictionary<string, IntPtr>();
        }

        public static void InitDataSystem(string dataPath, string localizationExtension)
        {
            if (Wrapper.InitGameDataSystem(dataPath, localizationExtension, false, false, true, false))
                Logger.Info("Game database successfully loaded from {0}", dataPath);
            else
                throw new Exception($"Could not load game database from {dataPath}");
            _databasePtr = Wrapper.GetMainDatabase();
            _databaseHandle = new HandleRef(new object(), _databasePtr);
        }

        public static void Populate(string[] fileNames)
        {
            Logger.Info("Start populating game database with {0} files", fileNames.Length);
            var missing = 0;
            foreach (var file in fileNames)
            {
                var dbid = Wrapper.GetDBIDByName(_databaseHandle, file);
                if (!Wrapper.DoesObjectExist(_databasePtr, dbid))
                {
                    //Logger.Warn("Object {0} does not exist in game database", file);
                    missing++;
                }
                else
                {
                    var ptr = Wrapper.GetObject(_databasePtr, dbid);
                    Index.Add(ptr, file);
                    ReversedIndex.Add(file, ptr);
                    //Logger.Debug("Object {0} added to database", file);
                }
            }

            Logger.Info("Game database populated with {0} files, {1} files are missing", fileNames.Length - missing,
                missing);
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
            if (!Index.TryGetValue(ptr, out var result)) throw new Exception("Could not find object name");
            return result;
        }
    }
}