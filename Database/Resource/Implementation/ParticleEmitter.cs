using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ParticleEmitter : Resource
    {
        [MemoryOffset(29)] [XdbElement] public Bool DecalEmitter;
        [MemoryOffset(28)] [XdbElement] public Bool DistortionEmitter;
        [MemoryOffset(8)] [XdbElement] public Float PivotX;
        [MemoryOffset(12)] [XdbElement] public Float PivotY;
        [MemoryOffset(16)] [XdbElement] public AsciiString Name;
        [MemoryOffset(36)][XdbElement("WorldSpaceEmitter")] public Bool WorldSpaceEmitter;

        [MemoryOffset(48)] [XdbEnum(typeof(ParticleAnimation.BlendEffect), "BlendEffect")]
        public Int BlendEffect;
        [MemoryOffset(40)] [XdbEnum(typeof(ParticleAnimation.RenderEffect), "RenderEffect")]
        public Int RenderEffect;

        [MemoryOffset(4)] [XdbElement] public Float VirtualOffset;
        [MemoryOffset(44)] [XdbElement("Color")] public Int Color;
        [MemoryOffset(37)] [XdbElement("UseLooping")] public Bool UseLooping;
        [MemoryOffset(32)] [XdbElement] public Float AmbientLightFactor;
    }
}