using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VisibilityInterval : Resource
    {
        [MemoryOffset(8)] [XdbElement] public Float BeginFadeDistance;
        [MemoryOffset(4)] [XdbElement] public Float EndFadeDistance;
    }
}