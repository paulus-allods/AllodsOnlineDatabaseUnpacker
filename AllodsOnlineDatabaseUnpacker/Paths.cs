using System;
using System.IO;

namespace AllodsOnlineDatabaseUnpacker
{
    internal static class Paths
    {
        public static readonly string DataDir = Directory.GetParent(Environment.CurrentDirectory).FullName + "\\Data";
    }
}