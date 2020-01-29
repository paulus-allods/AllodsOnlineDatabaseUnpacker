using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Int : DataType
    {
        private int value;

        public override XElement Serialize(string name)
        {
            return new XElement(name, value);
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            value = Marshal.ReadInt32(memoryAddress);
        }

        public static implicit operator int(Int x)
        {
            return x.value;
        }
    }
}