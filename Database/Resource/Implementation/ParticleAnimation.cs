using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ParticleAnimation : Resource
    {
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

        [MemoryOffset(124)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(112)] [XdbElement] public Blob Animation;
        [MemoryOffset(100)] [XdbElement] public TextFileRef BinaryFile;
        [MemoryOffset(96)] [XdbElement] public Int EndFrame;
        [MemoryOffset(84)] [XdbElement] public VisibilityInterval Fade;
        [MemoryOffset(76)] [XdbElement] public Bool Looped;
        [MemoryOffset(80)] [XdbElement] public Int LoopFrame;
        [MemoryArrayOffset(148, 52)] [XdbArray("ParticleEmitters")] public ParticleEmitter[] ParticleEmitters;
        [MemoryOffset(72)] [XdbElement] public Float ScaleDistanceEnd;
        [MemoryOffset(68)] [XdbElement] public Float ScaleDistanceStart;
        [MemoryArrayOffset(52, 8)] [XdbArray] public FileRef[] SingleTextures;
        [MemoryOffset(48)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        [MemoryOffset(44)] [XdbElement] public Float Speed;
        [MemoryOffset(40)] [XdbElement] public Int StartFrame;
        [MemoryArrayOffset(24, 8)] [XdbArray] public FileRef[] Textures;
    }
}