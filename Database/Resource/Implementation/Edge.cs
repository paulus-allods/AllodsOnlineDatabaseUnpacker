using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Edge : Resource
    {
        [MemoryOffset(16)] [XdbElement] public Vector3 Beg;
        [MemoryOffset(4)] [XdbElement] public Vector3 End;
    }
}