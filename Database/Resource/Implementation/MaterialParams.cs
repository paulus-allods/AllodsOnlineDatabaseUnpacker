using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class MaterialParams : Resource
    {
        [MemoryOffset(60)] [XdbElement] public Float ContourColorModifier;
        [MemoryOffset(52)] [XdbElement] public FileRef EffectMaskTexture;
        [MemoryOffset(44)] [XdbElement] public FileRef EnvReflectionTexture;
        [MemoryOffset(36)] [XdbElement] public FileRef EnvSpecularTexture;
        [MemoryOffset(32)] [XdbElement] public Bool Selfillum;
        [MemoryOffset(28)] [XdbElement] public Float SpecularColorModifier;
        [MemoryOffset(24)] [XdbElement] public Bool VertexBakedLight;
    }
}