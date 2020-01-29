using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.DataType.Implementation
{
    [UsedImplicitly]
    public class GenericField<T> : DataType where T : Resource.Resource, new()
    {
        private string className;
        private T content;

        public override void Deserialize(IntPtr memoryAddress)
        {
            var objectAddress = Marshal.ReadIntPtr(memoryAddress);
            if (objectAddress == IntPtr.Zero) return;
            var metaDataAddress = Marshal.ReadIntPtr(objectAddress + 12);
            var name = new AsciiString();
            name.Deserialize(metaDataAddress + 16);
            className = name.ToString().Split('.').Last();
            var type = Type.GetType($"Database.Resource.Implementation.{this.className}");
            if (type is null)
            {
                Logger.Warn($"Missing generic field {this.className} for {typeof(T)} ");
                content = new T();
            }
            else
            {
                if (!typeof(T).IsAssignableFrom(type))
                    throw new Exception($"Cannot assign {typeof(T)} from {type}");
                content = Activator.CreateInstance(type) as T;
                if (content is null) throw new Exception("Content is null");
            }

            content.Deserialize(objectAddress);
        }

        public override XElement Serialize(string name)
        {
            if (content is null) return new XElement(name);
            var element = content.Serialize(name);
            element.SetAttributeValue("type", className);
            return element;
        }
    }
}