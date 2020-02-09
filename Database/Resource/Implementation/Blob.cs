using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Blob : Resource
    {
        [MemoryOffset(8)] [XdbElement("localID")] public Int LocalId;
        [MemoryOffset(4)] [XdbElement] public Int Size;
    }
}