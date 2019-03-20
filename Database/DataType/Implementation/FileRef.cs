using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class FileRef : DataType
    {
        private IntPtr _href;

        public override XElement Serialize(string name)
        {
            return new XElement(name, new XAttribute("href", GameDatabase.GetObjectName(_href)));
        }

        public override void Deserialize(IntPtr memoryAddress)
        {
            _href = Marshal.ReadIntPtr(memoryAddress);
        }
    }
}