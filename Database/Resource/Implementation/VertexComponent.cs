using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VertexComponent : Resource
    {
        [MemoryOffset(8)] [XdbElement] public Int Offset;

        [MemoryOffset(4)] [XdbEnum(typeof(VertexElementType))]
        public Int Type;
    }
}