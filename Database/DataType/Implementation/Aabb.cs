using System;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Aabb : DataType
    {
        private readonly Vector3 center;
        private readonly Vector3 extents;

        public Aabb()
        {
            center = new Vector3();
            extents = new Vector3();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, center.Serialize("center"), extents.Serialize("extents"));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            center.Deserialize(memoryAddress);
            extents.Deserialize(memoryAddress + 12);
        }
    }
}