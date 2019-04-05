using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class BoneTransform : Resource
    {
        [MemoryOffset(4)] [XdbElement] public Vector3 Power;
        [MemoryOffset(16)] [XdbElement] public AsciiString BoneName;
    }
}