using System;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Vector2 : DataType
    {
        private readonly Float x;
        private readonly Float y;

        public Vector2()
        {
            x = new Float();
            y = new Float();
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            x.Deserialize(memoryAddress);
            y.Deserialize(memoryAddress + 4);
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("x", (float) x), new XAttribute("y", (float) y));
        }
    }
}