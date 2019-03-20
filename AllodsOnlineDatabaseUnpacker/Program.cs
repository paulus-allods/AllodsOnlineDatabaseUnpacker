using System;
using Database;
using NLog;

namespace AllodsOnlineDatabaseUnpacker
{
    internal static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            Logger.Info("Starting unpacker");
            EditorDatabase.InitDataSystem(Paths.DataDir, "");
            EditorDatabase.Populate();
            GameDatabase.InitDataSystem(Paths.DataDir, "");
            GameDatabase.Populate(EditorDatabase.GetObjectList());
            Console.ReadKey();
        }
    }
}