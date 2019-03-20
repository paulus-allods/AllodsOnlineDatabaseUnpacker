using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Bool : DataType
    {
        private bool _value;

        public override XElement Serialize(string name)
        {
            return new XElement(name, _value);
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            var result = Marshal.ReadByte(memoryAddress);
            switch (result)
            {
                case 0:
                    _value = false;
                    break;
                case 1:
                    _value = true;
                    break;
                default:
                    throw new Exception($"Cannot cast {result} to bool");
            }
        }
    }
}