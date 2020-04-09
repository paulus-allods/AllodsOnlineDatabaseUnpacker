using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class FileRef : DataType
    {
        private IntPtr href;

        public override XElement Serialize(string name)
        {
            if (href == IntPtr.Zero) return new XElement(name, new XAttribute("href", ""));
            var cursor = Marshal.ReadIntPtr(href + 12);
            var readByte = Marshal.ReadByte(cursor);
            var sb = new StringBuilder();
            while (readByte != 0)
            {
                sb.Append(Convert.ToChar(readByte));
                cursor += 1;
                readByte = Marshal.ReadByte(cursor);
            }

            var fileName = sb.ToString();
            var className = Utils.GetClassName(fileName);
            
            if (!GameDatabase.DoesFileExists(fileName))
            {
                Logger.Warn($"{fileName} is not indexed, it will be processed in next batch");
                GameDatabase.AddNotIndexedDependency(fileName);
            }

            return new XElement(name, new XAttribute("href", $"/{fileName}#xpointer(/{className})"));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            href = Marshal.ReadIntPtr(memoryAddress);
        }
    }
}