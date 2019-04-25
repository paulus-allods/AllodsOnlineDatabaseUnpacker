using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class AnimationsList : Resource
    {
        [MemoryOffset(4)] [XdbElement] public Bool UseAnimations;
        [MemoryArrayOffset(8,12)] [XdbArray] public AnimationSettings[] Animations;
    }
}