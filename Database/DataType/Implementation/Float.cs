using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Float : DataType
    {
        private float _value;

        public override void Deserialize(IntPtr memoryAddress)
        {
            var buffer = new byte[4];
            for (var i = 0; i < 4; i++) buffer[i] = Marshal.ReadByte(memoryAddress + i);
            _value = BitConverter.ToSingle(buffer, 0);
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, _value);
        }
    }
}