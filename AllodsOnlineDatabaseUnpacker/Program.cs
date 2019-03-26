using System;
using Database;
using Database.Resource.Implementation;
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
            var ptr = GameDatabase.GetObjectPtr(
                "Characters/Hadagan_female/Variations/HadaganFemaleVariations.(CharacterVariations).xdb");
            Logger.Debug(ptr.ToString("x8"));
            var ap = new CharacterVariations();
            ap.Deserialize(ptr);
            Console.ReadKey();
            Logger.Info(ap.Serialize("test"));
        }
    }
}