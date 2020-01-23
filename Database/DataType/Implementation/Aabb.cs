using System;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class Aabb : DataType
    {
        private readonly Vector3 _center;
        private readonly Vector3 _extents;

        public Aabb()
        {
            _center = new Vector3();
            _extents = new Vector3();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, _center.Serialize("center"), _extents.Serialize("extents"));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _center.Deserialize(memoryAddress);
            _extents.Deserialize(memoryAddress + 12);
        }
    }
}