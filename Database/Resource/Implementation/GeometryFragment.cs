using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class GeometryFragment : Resource
    {
        [MemoryOffset(16)] [XdbElement] public Int IndexBufferBegin;
        [MemoryOffset(12)] [XdbElement] public Int IndexBufferEnd;
        [MemoryOffset(8)] [XdbElement] public Int VertexBufferBegin;
        [MemoryOffset(4)] [XdbElement] public Int VertexBufferEnd;
    }
}