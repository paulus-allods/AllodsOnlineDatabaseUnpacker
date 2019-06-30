using System;
using System.Text.RegularExpressions;

namespace Database
{
    public static class Utils
    {
        private static readonly Regex ClassRegex = new Regex(@"\((.+)\)\.xdb");
        private static readonly Regex ClassRegex2 = new Regex(@"\/([^\/]+)\.xdb");

        enum Directory
        {
            Characters,
            Client,
            Creatures,
            Editor,
            Interface,
            ItemMall,
            Items,
            Maps,
            Material,
            Mechanics,
            Mods,
            SFX,
            Ships,
            Spells,
            System,
            World
        }
        
        
        public static string GetClassName(string filePath)
        {
            var match = ClassRegex.Match(filePath);
            if (!match.Success)
            {
                match = ClassRegex2.Match(filePath);
                if (!match.Success)
                {
                    throw new Exception($"Cannot find class name for {filePath}");
                }
            }
            return match.Groups[1].ToString();
            
        }

        public static string NormalizePath(string filePath)
        {
            var parts = filePath.Split('/');
            if (parts.Length > 1 && Enum.IsDefined(typeof(Directory), parts[0]))
            {
                return $"/{filePath}";
            }
            return filePath;
        }
    }
}