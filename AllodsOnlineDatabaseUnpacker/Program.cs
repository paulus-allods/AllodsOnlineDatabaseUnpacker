using System;
using System.IO;
using System.Reflection;
using Database;
using Database.Resource.Implementation;
using Microsoft.Extensions.CommandLineUtils;
using NLog;

namespace AllodsOnlineDatabaseUnpacker
{
    internal static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.Name = "AlldosDatabaseUnpacker.exe";
            app.Description = "Allods pack.bin database unpacker";

            app.HelpOption("-?|-h|--help");

            var dataDirArgument = app.Argument("data", "Allods data directory (default: data)");
            var exportFolderOption = app.Option("-f|--folder", "Export folder (default: export)", CommandOptionType.SingleValue);
            var devModeOption = app.Option("-d|--dev", "Enable dev mode for memory exploration (default: false)", CommandOptionType.NoValue);
            var testModeOption = app.Option("-t|--test", "Run unpacker without exporting files (default: false)", CommandOptionType.NoValue);
            var indexModeOption = app.Option("-i|--index", "Export editor index to file", CommandOptionType.SingleValue);
            var missingExportModeOption = app.Option("-m|--missing", "Export missing files list to file", CommandOptionType.SingleValue);
            var filesList = app.Option("-l|--list", "Files list to extract", CommandOptionType.SingleValue);

            app.OnExecute(() =>
            {
                var exportFolder = exportFolderOption.HasValue() ? exportFolderOption.Value() : "export";
                var devMode = devModeOption.HasValue();
                var testMode = testModeOption.HasValue();
                var dataDir = dataDirArgument.Value ?? "data";
                var indexFile = indexModeOption.HasValue() ? indexModeOption.Value() : null;
                var missingFilesFile = missingExportModeOption.HasValue() ? missingExportModeOption.Value() : null;

                Logger.Info("Initializing editor data system");
                EditorDatabase.InitDataSystem(dataDir, "");
                EditorDatabase.Populate();

                Logger.Info("Initializing game data system");
                GameDatabase.InitDataSystem(dataDir, "");

                var objectList = EditorDatabase.GetObjectList();

                if (!(indexFile is null))
                {
                    File.WriteAllLines(indexFile, objectList);
                }

                if (devMode)
                {
                    string cmd;
                    while ((cmd = Console.ReadLine()) != "exit")
                    {
                        try
                        {
                            var ptr = GameDatabase.GetObjectPtr(cmd);
                            Logger.Info(ptr.ToString("x8"));
                        }
                        catch (Exception e)
                        {
                            Logger.Error(e.Message);
                        }
                    }
                }
                else
                {
                    var unpacker = new Unpacker(testMode, exportFolder);
                    objectList = filesList.HasValue() ? File.ReadAllLines(filesList.Value()) : objectList;
                    unpacker.Run(objectList);
                    if (!(missingFilesFile is null))
                    {
                        var missingList = GameDatabase.GetMissingFiles();
                        File.WriteAllLines(missingFilesFile, missingList);
                    }
                }

                return 0;
            });

            try
            {
                app.Execute(args);
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
            }
            finally
            {
                Console.WriteLine("Program finished, press any key to exit ...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}