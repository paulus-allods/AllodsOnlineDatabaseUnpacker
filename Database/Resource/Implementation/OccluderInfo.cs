using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class OccluderInfo : Resource
    {
        [MemoryOffset(36)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(24)] [XdbElement] public Vector3 Center;
        [MemoryOffset(16)] [XdbElement] public Vector2 X;
        [MemoryOffset(8)] [XdbElement] public Vector2 Y;
        [MemoryOffset(4)] [XdbElement] public Float Z;
    }
}