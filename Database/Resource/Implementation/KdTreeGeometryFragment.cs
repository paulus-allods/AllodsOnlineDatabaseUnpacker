using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class KdTreeGeometryFragment : Resource
    {
        [MemoryOffset(12)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(4)] [XdbElement] public Blob Blob;
    }
}