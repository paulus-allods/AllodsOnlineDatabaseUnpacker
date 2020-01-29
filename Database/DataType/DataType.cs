using System;
using System.Xml.Linq;
using Database.Serialization.Memory;
using Database.Serialization.XDB;
using NLog;

namespace Database.DataType
{
    public abstract class DataType : IXdbSerializable, IMemoryDeserializable
    {
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public abstract void Deserialize(IntPtr memoryAddress);
        public abstract XElement Serialize(string name);
    }
}