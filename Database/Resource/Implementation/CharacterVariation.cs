using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class CharacterVariation : Resource
    {
        [MemoryOffset(68)] [XdbElement] public FileRef AdditionalVariation;
        [MemoryOffset(60)] [XdbElement] public FileRef Face;
        [MemoryOffset(52)] [XdbElement] public FileRef Facial;
        [MemoryOffset(48)] [XdbElement] public Int FacialColor;
        [MemoryOffset(44)] [XdbElement] public Int HairColor;
        [MemoryOffset(36)] [XdbElement] public FileRef HairGeoset;
        [MemoryOffset(4)] [XdbElement] public FileRef Skin;
        [MemoryOffset(0)] [XdbElement] public Int SkinColor;
        [MemoryOffset(12)] [XdbElement] public ModelMorphPreset MorphPreset;
    }
}