using System;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class TextFileRef : DataType
    {
        private readonly AsciiString href;

        public TextFileRef()
        {
            href = new AsciiString();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("href", href));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            href.Deserialize(memoryAddress);
        }
    }
}