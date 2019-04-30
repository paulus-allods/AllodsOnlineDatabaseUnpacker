using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class CharacterVariations : Resource
    {
        [MemoryArrayOffset(220, 8)] [XdbArray] public FileRef[] Additional;
        [MemoryOffset(144)] [XdbElement] public CharacterVariation DefaultVariation;
        [MemoryArrayOffset(124, 8)] [XdbArray] public FileRef[] Faces;
        [MemoryArrayOffset(108, 8)] [XdbArray] public FileRef[] Facial;
        [MemoryArrayOffset(92, 4)] [XdbArray] public Int[] FacialColors;
        [MemoryArrayOffset(76, 8)] [XdbArray] public FileRef[] Hair;
        [MemoryArrayOffset(60, 4)] [XdbArray] public Int[] HairColors;
        [MemoryOffset(56)] [XdbElement] public Bool IgnoreHairColor;
        [MemoryArrayOffset(40, 8)] [XdbArray] public FileRef[] MainTextures;
        [MemoryArrayOffset(24, 4)] [XdbArray] public Int[] SkinColors;
    }
}