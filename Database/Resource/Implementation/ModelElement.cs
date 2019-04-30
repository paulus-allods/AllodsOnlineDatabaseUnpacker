using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ModelElement : Resource
    {
        [MemoryArrayOffset(96, 16)] [XdbArray] public GeometryFragment[] Lods;
        [MemoryOffset(44)] [XdbElement] public MaterialInstance Material;
        [MemoryOffset(32)] [XdbElement] public AsciiString MaterialName;
        [MemoryOffset(20)] [XdbElement] public AsciiString Name;
        [MemoryOffset(16)] [XdbElement] public Int SkinIndex;
        [MemoryOffset(12)] [XdbElement] public Int VertexBufferOffset;

        [MemoryOffset(8)] [XdbElement("vertexDeclarationID")]
        public Int VertexDeclarationId;

        [MemoryOffset(4)] [XdbElement] public Float VirtualOffset;
    }
}