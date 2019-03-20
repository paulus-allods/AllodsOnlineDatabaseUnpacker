using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Int : DataType
    {
        private int _value;

        public override XElement Serialize(string name)
        {
            return new XElement(name, _value);
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _value = Marshal.ReadInt32(memoryAddress);
        }

        public static implicit operator int(Int x)
        {
            return x._value;
        }
    }
}