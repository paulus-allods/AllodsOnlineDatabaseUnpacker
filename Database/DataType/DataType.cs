using System;
using System.Xml.Linq;
using Database.Serialization.Memory;
using Database.Serialization.XDB;
using JetBrains.Annotations;
using NLog;

namespace Database.DataType
{
    [UsedImplicitly]
    public abstract class DataType : IXdbSerializable, IMemoryDeserializable
    {
        protected static Logger Logger = LogManager.GetCurrentClassLogger();
        public abstract void Deserialize(IntPtr memoryAddress);
        public abstract XElement Serialize(string name);
    }
}