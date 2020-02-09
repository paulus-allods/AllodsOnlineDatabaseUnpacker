using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VertexDeclaration : Resource
    {
        [MemoryOffset(80)] [XdbElement] public VertexComponent Color;
        [MemoryOffset(68)] [XdbElement] public VertexComponent Indices;
        [MemoryOffset(56)] [XdbElement] public VertexComponent Normal;
        [MemoryOffset(44)] [XdbElement] public VertexComponent Position;
        [MemoryOffset(40)] [XdbElement] public Int Stride;
        [MemoryOffset(28)] [XdbElement] public VertexComponent Texcoord0;
        [MemoryOffset(16)] [XdbElement] public VertexComponent Texcoord1;
        [MemoryOffset(4)] [XdbElement] public VertexComponent Weights;
    }
}