using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Float : DataType
    {
        private float value;

        public override void Deserialize(IntPtr memoryAddress)
        {
            var buffer = new byte[4];
            for (var i = 0; i < 4; i++) buffer[i] = Marshal.ReadByte(memoryAddress + i);
            value = BitConverter.ToSingle(buffer, 0);
        }

        public static implicit operator float(Float x)
        {
            return x.value;
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, value);
        }
    }
}