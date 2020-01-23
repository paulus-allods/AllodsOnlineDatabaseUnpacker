using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class AnimationProperties : Resource
    {
        [MemoryOffset(162)] [XdbElement] public Bool CanWalkBackwards;
        [MemoryOffset(161)] [XdbElement] public Bool FinishMoveAnimation;
        [MemoryOffset(160)] [XdbElement] public Bool GroundNormalByBoundingBox;
        [MemoryOffset(148)] [XdbElement] public AsciiString HeadBoneName;
        [MemoryOffset(144)] [XdbElement] public Float HeadTurnTime;
        [MemoryOffset(140)] [XdbEnum(typeof(CreatureKind))] public Int Kind;
        [MemoryOffset(136)] [XdbElement] public Float LegAlignTime;
        [MemoryOffset(132)] [XdbElement] public Float LegRunTurnTime;
        [MemoryOffset(128)] [XdbElement] public Float MaxHeadAngle;
        [MemoryOffset(124)] [XdbElement] public Bool MoveAnimationsNoScale;
        [MemoryOffset(120)] [XdbElement] public Float Run;
        [MemoryOffset(112)] [XdbElement] public SpecialShuffleParams SpecialShuffleParams;
        [MemoryOffset(96)] [XdbElement] public AsciiString SpineBoneName;
        [MemoryOffset(92)] [XdbElement] public Float SwimHeight;
        [MemoryOffset(36)] [XdbElement] public TargetTrackingParams TargetTrackingParams;
        [MemoryOffset(28)] [XdbElement] public Float Walk;
        [MemoryOffset(24)] [XdbElement] public Float WalkBackwards;
    }
}