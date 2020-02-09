using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Bool : DataType
    {
        private bool value;

        public override XElement Serialize(string name)
        {
            return new XElement(name, value);
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            var result = Marshal.ReadByte(memoryAddress);
            switch (result)
            {
                case 0:
                    value = false;
                    break;
                case 1:
                    value = true;
                    break;
                default:
                    throw new Exception($"Cannot cast {result} to bool");
            }
        }
    }
}