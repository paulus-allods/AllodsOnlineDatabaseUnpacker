using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class SkeletonPart : Resource
    {
        [MemoryOffset(16)] [XdbElement] public Bool EnableFlag;
        [MemoryOffset(4)] [XdbElement] public AsciiString RootBone;
        [MemoryOffset(0)] [XdbElement] public Bool RootFlag;
    }
}