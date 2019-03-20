using System;
using System.Reflection;
using System.Xml.Linq;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource
{
    public abstract class Resource : IMemoryDeserializable, IXdbSerializable
    {
        public void Deserialize(IntPtr memoryAddress)
        {
            foreach (var field in GetType().GetFields())
                using (var e = field.GetCustomAttributes(typeof(MemoryOffsetAttribute)).GetEnumerator())
                {
                    if (e.MoveNext() && e.Current is MemoryOffsetAttribute offsetAttribute)
                        offsetAttribute.DeserializeField(field, memoryAddress, this);
                }
        }

        public XElement Serialize(string name)
        {
            var root = new XElement(name);
            foreach (var field in GetType().GetFields())
            {
                var e = field.GetCustomAttributes(typeof(XdbElementAttribute), false).GetEnumerator();
                if (e.MoveNext() && e.Current is XdbElementAttribute xdbElementAttribute)
                    root.Add(xdbElementAttribute.SerializeField(field, this));
            }

            return root;
        }
    }
}