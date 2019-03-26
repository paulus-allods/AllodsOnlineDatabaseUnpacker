using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class SkeletonPart : Resource
    {
        [MemoryOffset(20)] [XdbElement] public Bool EnableFlag;
        [MemoryOffset(8)] [XdbElement] public AsciiString RootBone;
        [MemoryOffset(4)] [XdbElement] public Bool RootFlag;
    }
}