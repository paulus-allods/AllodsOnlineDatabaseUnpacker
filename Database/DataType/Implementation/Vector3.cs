using System;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Vector3 : DataType
    {
        private readonly Float _x;
        private readonly Float _y;
        private readonly Float _z;

        public Vector3()
        {
            _x = new Float();
            _y = new Float();
            _z = new Float();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("x", (float) _x), new XAttribute("y", (float) _y), new XAttribute("z", (float) _z));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _x.Deserialize(memoryAddress);
            _y.Deserialize(memoryAddress + 4);
            _z.Deserialize(memoryAddress + 8);
        }
    }
}