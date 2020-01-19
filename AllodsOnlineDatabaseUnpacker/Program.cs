using System;
using System.IO;
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
                    var ptr = GameDatabase.GetObjectPtr(cmd);
                    Logger.Info(ptr.ToString("x8"));
                    if (cmd != null && cmd.Contains("(CollisionMesh)"))
                    {
                        var result = new CollisionMesh();
                        result.Deserialize(ptr);
                        var output = result.Serialize("CollisionMesh");
                        Console.WriteLine(output);
                    }
                }
            }
            else if (args.Length > 1 && args[0] == "--list")
            {
                var unpacker = new Unpacker(true, "export");
                var objectList = File.ReadAllLines(args[1]);
                unpacker.Run(objectList);
            }
            else
            {
                var unpacker = new Unpacker(true, "export");
                unpacker.Run(null);
            }
        }
    }
}