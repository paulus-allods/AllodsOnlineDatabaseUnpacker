using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class KdTreePortalFragment : Resource
    {
        [MemoryOffset(52)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(40)] [XdbElement] public Blob Blob;
        [MemoryArrayOffset(24, 28)] [XdbArray] public Edge[] Edges;
        [MemoryOffset(20)] [XdbElement] public Int LeftArea;
        [MemoryOffset(8)] [XdbElement] public Vector3 Normal;
        [MemoryOffset(4)] [XdbElement] public Int RightArea;
    }
}