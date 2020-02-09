using System;
using System.Runtime.InteropServices;
using Db;
using NLog;

namespace Database
{
    public static class EditorDatabase
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static IntPtr databasePtr;
        private static HandleRef databaseHandle;
        private static string[] objectList;

        public static void InitDataSystem(string dataPath, string localizationExtension)
        {
            if (Wrapper.InitEditorDataSystem(dataPath, localizationExtension, true, ""))
                Logger.Info("Editor data system successfully loaded from {0}", dataPath);
            else
                throw new Exception($"Could not load editor data system from {dataPath}");
            databasePtr = Wrapper.GetMainDatabase_static();
            databaseHandle = new HandleRef(databasePtr, databasePtr);
        }

        public static void Populate()
        {
            Logger.Info("Start populating editor database");
            var db = IDatabase.GetMainDatabase();
            db.Dispose(); //Magic memory trick
            objectList = Wrapper.GetObjectsList(databaseHandle, "").Split('\t');
            Logger.Info("{0} files have been loaded to editor database", objectList.Length);
        }

        public static string[] GetObjectList()
        {
            return objectList;
        }
    }
}