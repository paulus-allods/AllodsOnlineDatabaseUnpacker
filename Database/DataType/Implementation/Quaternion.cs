using System;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class Quaternion : DataType
    {
        private readonly Float w;
        private readonly Float x;
        private readonly Float y;
        private readonly Float z;

        public Quaternion()
        {
            x = new Float();
            y = new Float();
            z = new Float();
            w = new Float();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("x", (float) x), new XAttribute("y", (float) y), new XAttribute("z", (float) z), new XAttribute("w", (float) w));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            x.Deserialize(memoryAddress);
            y.Deserialize(memoryAddress + 4);
            z.Deserialize(memoryAddress + 8);
            w.Deserialize(memoryAddress + 12);
        }
    }
}