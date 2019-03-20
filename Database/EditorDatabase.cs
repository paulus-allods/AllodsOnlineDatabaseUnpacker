using System;
using System.Runtime.InteropServices;
using Db;
using NLog;

namespace Database
{
    public static class EditorDatabase
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static IntPtr _databasePtr;
        private static HandleRef _databaseHandle;

        private static string[] _objectList;

        public static void InitDataSystem(string dataPath, string localizationExtension)
        {
            if (Wrapper.InitEditorDataSystem(dataPath, localizationExtension, true, ""))
                Logger.Info("Editor database successfully loaded from {0}", dataPath);
            else
                throw new Exception($"Could not load game database from {dataPath}");
            _databasePtr = Wrapper.GetMainDatabase_static();
            _databaseHandle = new HandleRef(_databasePtr, _databasePtr);
        }

        public static void Populate()
        {
            Logger.Info("Start populating editor database");
            var db = IDatabase.GetMainDatabase();
            db.Dispose(); //Magic memory trick
            _objectList = Wrapper.GetObjectsList(_databaseHandle, "").Split('\t');
            Logger.Info("{0} files have been loaded to editor database", _objectList.Length);
        }

        public static string[] GetObjectList()
        {
            return _objectList;
        }
    }
}