using System;
using System.IO;
using System.Runtime.InteropServices;
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
            if (args.Length > 0 && args[0] == "--dev")
            {
                EditorDatabase.InitDataSystem(Paths.DataDir, "");
                EditorDatabase.Populate();
                GameDatabase.InitDataSystem(Paths.DataDir, "");
                var objectList = EditorDatabase.GetObjectList();
                GameDatabase.Populate(objectList);
                string cmd;
                while ((cmd = Console.ReadLine()) != "exit")
                {
                    try
                    {
                        var ptr = GameDatabase.GetObjectPtr(cmd);
                        Logger.Info(ptr.ToString("x8"));
                        if (cmd != null && cmd.Contains("(Visual3Mob)"))
                        {
                            var result = new VisualMob();
                            result.Deserialize(ptr);
                            var output = result.Serialize("VisObjectTemplate");
                            Console.WriteLine(output);
                        }
                    }
                    catch (Exception e)
                    {
                        Logger.Error(e.Message);
                    }
                }
            }
            else
            {
                var unpacker = new Unpacker(true,"export");
                unpacker.Run();
            }
        }
    }
}