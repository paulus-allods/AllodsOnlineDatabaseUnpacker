using System;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class TextFileRef : DataType
    {
        private readonly AsciiString _href;

        public TextFileRef()
        {
            _href = new AsciiString();
        }

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("href", _href));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _href.Deserialize(memoryAddress);
        }
    }
}