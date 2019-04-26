using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ModelPart : Resource
    {
        [MemoryOffset(44)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(40)] [XdbElement] public Bool AreaPart;
        [MemoryOffset(36)] [XdbElement] public Int EndElement;
        [MemoryArrayOffset(20, 12)] [XdbArray] public AsciiString[] ImplicitAreas;
        [MemoryOffset(8)] [XdbElement] public AsciiString Name;
        [MemoryOffset(32)] [XdbElement] public Int StartElement;
    }
}