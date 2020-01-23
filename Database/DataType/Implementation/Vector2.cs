using System;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Vector2 : DataType
    {
        private readonly Float _x;
        private readonly Float _y;

        public Vector2()
        {
            _x = new Float();
            _y = new Float();
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _x.Deserialize(memoryAddress);
            _y.Deserialize(memoryAddress + 4);
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("x", (float) _x), new XAttribute("y", (float) _y));
        }
    }
}