using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VisAction : Resource
    {
        [MemoryOffset(20)] [XdbElement] public AsciiString VisActionId;
    }
}