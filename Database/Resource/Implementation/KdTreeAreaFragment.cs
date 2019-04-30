using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class KdTreeAreaFragment : Resource
    {
        [MemoryOffset(68)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(64)] [XdbElement] public Int AreaId;

        [MemoryOffset(52)] [XdbElement] public Blob Blob;

        //TODO: [MemoryOffset()] [XdbElement] public AreaInfo AreaInfo;
        [MemoryArrayOffset(36, 28)] [XdbArray] public Edge[] Edges;
        [MemoryOffset(24)] [XdbElement] public AsciiString Name;
        [MemoryArrayOffset(8, 4)] [XdbArray] public Int[] Portals;
        [MemoryOffset(4)] [XdbElement] public Bool UseOcclusionTest;
    }
}