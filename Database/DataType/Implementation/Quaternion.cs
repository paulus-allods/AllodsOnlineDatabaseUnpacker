using System;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Quaternion : DataType
    {
        private readonly Float _w;
        private readonly Float _x;
        private readonly Float _y;
        private readonly Float _z;

        public Quaternion()
        {
            _x = new Float();
            _y = new Float();
            _z = new Float();
            _w = new Float();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name,
                new XAttribute("x", _x),
                new XAttribute("y", _y),
                new XAttribute("z", _z),
                new XAttribute("w", _w));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _x.Deserialize(memoryAddress);
            _y.Deserialize(memoryAddress + 4);
            _z.Deserialize(memoryAddress + 8);
            _w.Deserialize(memoryAddress + 12);
        }
    }
}