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
            string cmd;
            while ((cmd = Console.ReadLine()) != "exit")
            {
                var ptr = GameDatabase.GetObjectPtr(cmd);
                Logger.Debug(ptr.ToString("x8"));
                if (cmd != null && cmd.Contains("(VisObjectTemplate)"))
                {
                    var result = new VisObjectTemplate();
                    result.Deserialize(ptr);
                    var output = result.Serialize("VisObjectTemplate");
                    Console.WriteLine(output);
                }
            }
        }
    }
}