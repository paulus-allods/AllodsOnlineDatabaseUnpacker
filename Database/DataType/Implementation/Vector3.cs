using System;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Vector3 : DataType
    {
        private readonly Float x;
        private readonly Float y;
        private readonly Float z;

        public Vector3()
        {
            x = new Float();
            y = new Float();
            z = new Float();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("x", (float) x), new XAttribute("y", (float) y), new XAttribute("z", (float) z));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            x.Deserialize(memoryAddress);
            y.Deserialize(memoryAddress + 4);
            z.Deserialize(memoryAddress + 8);
        }
    }
}