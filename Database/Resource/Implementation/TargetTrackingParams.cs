using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TargetTrackingParams : Resource
    {
        [MemoryArrayOffset(36, 4)] [XdbEnumArray(typeof(Animation))]
        public Int[] AddedToUseAnimations;

        [MemoryOffset(32)] [XdbElement] public Int HorizontalRotate;
        [MemoryOffset(0)] [XdbElement] public Bool IgnoreRotateToTarget;
        [MemoryOffset(24)] [XdbElement] public Float MaxHeadAngleToDown;
        [MemoryOffset(20)] [XdbElement] public Float MaxHeadAngleToSide;
        [MemoryOffset(16)] [XdbElement] public Float MaxHeadAngleToUp;
        [MemoryOffset(4)] [XdbElement] public AsciiString TargetBoneName;
        [MemoryOffset(28)] [XdbElement] public Bool Use;
        [MemoryOffset(1)] [XdbElement] public Bool UseInEveryAnimation;

        //TODO [MemoryOffset(0)] [XdbElement] public Int VerticalRotate;
    }
}