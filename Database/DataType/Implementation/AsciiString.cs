using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class AsciiString : DataType
    {
        private string value;

        public AsciiString(string value)
        {
            this.value = value;
        }

        public AsciiString() { }

        public override XElement Serialize(string name)
        {
            return value == string.Empty ? new XElement(name) : new XElement(name, value);
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            var startAddress = Marshal.ReadIntPtr(memoryAddress);
            var endAddress = Marshal.ReadIntPtr(memoryAddress + 4);
            var sb = new StringBuilder();
            for (var localPtr = startAddress; localPtr != endAddress; localPtr += 1)
            {
                var readByte = Marshal.ReadByte(localPtr);
                if (readByte != 0) sb.Append(Convert.ToChar(readByte));
            }

            value = sb.ToString();
        }

        public override string ToString()
        {
            return Utils.NormalizePath(value);
        }
    }
}