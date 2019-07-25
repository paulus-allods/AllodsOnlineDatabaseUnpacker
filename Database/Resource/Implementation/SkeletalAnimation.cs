using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class SkeletalAnimation : Resource
    {
        [MemoryOffset(136)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(112)] [XdbElement] public Aabb AabbLastFrame;
        [MemoryOffset(100)] [XdbElement] public Blob Animation; //TODO: Verify
        [MemoryArrayOffset(84, 24)] [XdbArray] public AnimationEvent[] AnimationEvents;
        [MemoryOffset(72)] [XdbElement] public TextFileRef BinaryFile;
        [MemoryOffset(68)] [XdbElement] public Int BinaryVersion;
        [MemoryOffset(64)] [XdbElement] public Float BlendTime;
        [MemoryOffset(60)] [XdbElement] public Int EndFrame;
        [MemoryOffset(56)] [XdbElement] public Float Fps;
        [MemoryOffset(52)] [XdbElement] public Bool Looped;
        [MemoryOffset(48)] [XdbElement("scriptID")] public Int ScriptId;
        [MemoryOffset(36)] [XdbElement] public AsciiString ScriptName;
        [MemoryOffset(32)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        [MemoryOffset(28)] [XdbElement] public Float Speed;
        [MemoryOffset(24)] [XdbElement] public Int StartFrame; //TODO: Verify

        public class AnimationEvent : Resource
        {
            [MemoryOffset(20)] [XdbElement] public Float Event;
            [MemoryOffset(16)] [XdbElement] public Int Id;
            [MemoryOffset(4)] [XdbElement] public AsciiString Name;
        }
    }
}