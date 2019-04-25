using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class MobAnimations : Resource
    {
        [MemoryOffset(264)] [XdbElement] public AnimationsList Attack;
        //TODO: [MemoryOffset()] [XdbElement] public AnimationsList AttackSwim;
        //TODO: [MemoryArrayOffset(,16)] [XdbArray] public RandomSpellVisScript[] MeleeAttackScripts;
        [MemoryArrayOffset(120,16)] [XdbArray]public RandomSpellVisScript[] RangedAttackScripts;
        [MemoryOffset(192)] [XdbElement] public AnimationsList Idle;
        //TODO: [MemoryOffset()] [XdbElement] public AnimationsList IdleSwim;
        [MemoryOffset(24)] [XdbElement] public AnimationsList Walk;
        [MemoryOffset(96)] [XdbElement] public AnimationsList Run;
        //TODO: [MemoryOffset()] [XdbElement] public AnimationsList Swim;
        //TODO: [MemoryOffset()] [XdbElement] public AnimationsList Death;
        [MemoryOffset(184)] [XdbElement] public Int IdlePeriodMin;
        [MemoryOffset(188)] [XdbElement] public Int IdlePeriodMax;
        [MemoryOffset(152)] [XdbElement] public Int IdleSwimPeriodMin;
        [MemoryOffset(156)] [XdbElement] public Int IdleSwimPeriodMax;
        [MemoryOffset(72)] [XdbElement] public SpecialIdleParams SpecialIdleParams;
    }
}