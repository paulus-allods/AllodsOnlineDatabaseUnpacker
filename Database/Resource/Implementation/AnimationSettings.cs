using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class AnimationSettings : Resource
    {
        [MemoryOffset(8)] [XdbEnum(typeof(Animation))] public Int Animation;
        [MemoryOffset(4)] [XdbElement] public Int Rate;
    }
}