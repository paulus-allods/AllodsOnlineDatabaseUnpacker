using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class KDTreeGeometryFragment : Resource
    {
        [MemoryOffset(16)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(4)] [XdbElement] public Blob Blob;
    }
}