using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VisualMob : Resource
    {
        [MemoryOffset(224)] [XdbElement] public FileRef Character;
        [MemoryOffset(200)] [XdbElement] public AmbientCoefficients ColorCoefficients;
        [MemoryOffset(196)] [XdbEnum(typeof(Animation))] public Int FixedIdleAnimation;
        [MemoryArrayOffset(180, 16)] [XdbArray] public DressedItem[] Items;
        [MemoryOffset(172)] [XdbElement] public FileRef MobAnimations;
        [MemoryOffset(164)] [XdbElement] public FileRef MobEventsScripts;
        [MemoryOffset(160)] [XdbElement] public GenericField<VisualMobExtension> MobExtension;
        [MemoryOffset(156)] [XdbElement] public Float Scale;
        [MemoryOffset(148)] [XdbElement] public FileRef SfxArmorSet;
        [MemoryOffset(140)] [XdbElement] public FileRef SoundVariation;
        [MemoryOffset(136)] [XdbElement] public Int TimeToCorpseFadingMax;
        [MemoryOffset(132)] [XdbElement] public Int TimeToCorpseFadingMin;
        [MemoryOffset(128)] [XdbElement] public Float Transparency;
        [MemoryOffset(125)] [XdbElement] public Bool UseVisCharacterIntervalVisScripts;
        [MemoryOffset(124)] [XdbElement] public Bool UseVisualTweaks;
        [MemoryOffset(48)] [XdbElement] public CharacterVariation Variation;
        [MemoryOffset(40)] [XdbElement] public GenericField<VisAction> VisualScript;
        [MemoryArrayOffset(24, 8)] [XdbArray] public FileRef[] VisualStates;

        public class DressedItem : Resource
        {
            [MemoryOffset(8)] [XdbElement] public FileRef Item;
            [MemoryOffset(4)] [XdbEnum(typeof(DressSlot))] public Int Slot;
        }
    }
}