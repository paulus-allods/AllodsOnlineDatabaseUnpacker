using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ParticleAnimation : Resource
    {
        [MemoryOffset(112)] [XdbElement] public Blob Animation;
        [MemoryOffset(76)] [XdbElement] public Bool Looped;
        [MemoryOffset(100)] [XdbElement] public AsciiString BinaryFile;

        [MemoryOffset(48)] [XdbElement("sourceFileCRC")]
        public Int SourceFileCrc;

        [MemoryOffset(68)] [XdbElement] public Float ScaleDistanceStart;
        [MemoryOffset(72)] [XdbElement] public Float ScaleDistanceEnd;
        [MemoryOffset(40)] [XdbElement] public Int StartFrame;
        [MemoryOffset(96)] [XdbElement]  public Int EndFrame;
        [MemoryOffset(80)] [XdbElement] public Int LoopFrame;
        [MemoryOffset(44)] [XdbElement] public Float Speed;
        [MemoryArrayOffset(24,8)] [XdbArray] public FileRef[] Textures;
        [MemoryArrayOffset(52,8)] [XdbArray] public FileRef[] SingleTextures;
        [MemoryOffset(84)] [XdbElement] public VisibilityInterval Fade;

        [MemoryArrayOffset(148,52)] [XdbArray("ParticleEmitters")]
        public ParticleEmitter[] ParticleEmitters;

        [MemoryOffset(124)] [XdbElement] public Aabb Aabb;
        
        public enum BlendEffect
        {
            BLEND_EFFECT_ALPHA,
            BLEND_EFFECT_ADD
        }
        
        public enum RenderEffect
        {
            STD_MODE,
            Z_QUAD,
            Z_BOX
        }
    }
}