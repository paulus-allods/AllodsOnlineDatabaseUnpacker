using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class NamedJoint : Resource
    {
        [MemoryOffset(8)] [XdbElement] public Int Id;
        [MemoryOffset(4)] [XdbElement] public AsciiString Name;
    }
}