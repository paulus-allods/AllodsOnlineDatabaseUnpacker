using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class MobAnimations : Resource
    {
        [MemoryOffset(264)] [XdbElement] public AnimationsList Attack;
        [MemoryOffset(240)] [XdbElement] public AnimationsList AttackSwim;
        [MemoryOffset(216)] [XdbElement] public AnimationsList Death;
        [MemoryOffset(192)] [XdbElement] public AnimationsList Idle;
        [MemoryOffset(188)] [XdbElement] public Int IdlePeriodMax;
        [MemoryOffset(184)] [XdbElement] public Int IdlePeriodMin;
        [MemoryOffset(160)] [XdbElement] public AnimationsList IdleSwim;
        [MemoryOffset(156)] [XdbElement] public Int IdleSwimPeriodMax;
        [MemoryOffset(152)] [XdbElement] public Int IdleSwimPeriodMin;
        [MemoryArrayOffset(136, 16)] [XdbArray] public RandomSpellVisScript[] MeleeAttackScripts;
        [MemoryArrayOffset(120, 16)] [XdbArray] public RandomSpellVisScript[] RangedAttackScripts;
        [MemoryOffset(96)] [XdbElement] public AnimationsList Run;
        [MemoryOffset(72)] [XdbElement] public SpecialIdleParams SpecialIdleParams;
        [MemoryOffset(48)] [XdbElement] public AnimationsList Swim;
        [MemoryOffset(24)] [XdbElement] public AnimationsList Walk;
    }
}