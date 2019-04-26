using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class AnimationsList : Resource
    {
        [MemoryArrayOffset(8, 12)] [XdbArray] public AnimationSettings[] Animations;
        [MemoryOffset(4)] [XdbElement] public Bool UseAnimations;
    }
}