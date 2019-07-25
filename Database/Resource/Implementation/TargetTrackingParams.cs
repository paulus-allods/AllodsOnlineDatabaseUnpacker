using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TargetTrackingParams : Resource
    {
        [MemoryArrayOffset(40, 4)] [XdbEnumArray(typeof(Animation))] public Int[] AddedToUseAnimations;
        [MemoryOffset(36)] [XdbEnum(typeof(Bone))] public Int HorizontalRotate;
        [MemoryOffset(4)] [XdbElement] public Bool IgnoreRotateToTarget;
        [MemoryOffset(28)] [XdbElement] public Float MaxHeadAngleToDown;
        [MemoryOffset(24)] [XdbElement] public Float MaxHeadAngleToSide;
        [MemoryOffset(20)] [XdbElement] public Float MaxHeadAngleToUp;
        [MemoryOffset(8)] [XdbElement] public AsciiString TargetBoneName;
        [MemoryOffset(32)] [XdbElement] public Bool Use;
        [MemoryOffset(5)] [XdbElement] public Bool UseInEveryAnimation;
        [MemoryOffset(0)] [XdbEnum(typeof(Bone))] public Int VerticalRotate;
    }
}