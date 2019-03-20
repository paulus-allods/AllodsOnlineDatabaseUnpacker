using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class AnimationController : Resource
    {
        [MemoryOffset(26)] [XdbElement] public Bool AnimationFeedBack;
        [MemoryOffset(25)] [XdbElement] public Bool DefaultFlag;

        [MemoryArrayOffset(28, 20)] [XdbArray("SkeletonParts")]
        public SkeletonPart[] SkeletonParts;

        [MemoryOffset(24)] [XdbElement] public Bool UseMaterialAnimation;
    }
}