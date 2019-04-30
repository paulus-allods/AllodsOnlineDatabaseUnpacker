using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Database.DataType.Implementation
{
    public class GenericField<T> : DataType where T : Resource.Resource, new()
    {
        private string _className;
        private T _content;

        public override void Deserialize(IntPtr memoryAddress)
        {
            var objectAddress = Marshal.ReadIntPtr(memoryAddress);
            if (objectAddress != IntPtr.Zero)
            {
                var metaDataAddress = Marshal.ReadIntPtr(objectAddress + 12);
                var className = new AsciiString();
                className.Deserialize(metaDataAddress + 16);
                _className = className.ToString().Split('.').Last();
                var type = Type.GetType($"Database.Resource.Implementation.{_className}");
                if (type is null)
                {
                    Logger.Warn($"Missing generic field {_className} for {typeof(T)} ");
                    _content = new T();
                }
                else
                {
                    if (!typeof(T).IsAssignableFrom(type))
                        throw new Exception($"Cannot assign {typeof(T)} from {type}");
                    _content = Activator.CreateInstance(type) as T;
                    if (_content is null) throw new Exception("Content is null");
                }

                _content.Deserialize(objectAddress);
            }
        }

        public override XElement Serialize(string name)
        {
            if (_content is null) return new XElement(name);
            var content = _content.Serialize(name);
            content.SetAttributeValue("type", _className);
            return content;
        }
    }
}