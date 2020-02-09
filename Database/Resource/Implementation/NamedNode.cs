using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class NamedNode : Resource
    {
        [MemoryOffset(36)] [XdbElement] public AsciiString Name;
        [MemoryOffset(24)] [XdbElement] public Vector3 Position;
        [MemoryOffset(8)] [XdbElement] public Quaternion Rotation;
        [MemoryOffset(4)] [XdbElement] public Float Scale;
    }
}