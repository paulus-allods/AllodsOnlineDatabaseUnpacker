using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class MaterialInstance : Resource
    {
        [MemoryOffset(48)] [XdbEnum(typeof(BlendEffect), "BlendEffect")] public Int BlendEffect;
        [MemoryOffset(40)] [XdbElement] public FileRef DiffuseTexture;
        [MemoryOffset(36)] [XdbElement] public GenericField<MaterialParams> Params;
        [MemoryOffset(33)] [XdbElement] public Bool ScrollAlpha;
        [MemoryOffset(32)] [XdbElement("ScrollRGB")] public Bool ScrollRgb;
        [MemoryOffset(24)] [XdbElement] public FileRef TransparencyTexture;
        [MemoryOffset(20)] [XdbElement] public Bool Transparent;
        [MemoryOffset(12)] [XdbElement] public Bool UseFog;
        [MemoryOffset(16)] [XdbElement] public Float UTranslateSpeed;
        [MemoryOffset(4)] [XdbElement] public Bool Visible;
        [MemoryOffset(8)] [XdbElement] public Float VTranslateSpeed;
    }
}