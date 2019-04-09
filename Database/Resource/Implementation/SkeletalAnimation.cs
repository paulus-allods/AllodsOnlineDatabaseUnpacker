using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class SkeletalAnimation : Resource
    {
        [MemoryOffset(100)] [XdbElement] public Blob Animation;//TODO: Verify
        [MemoryOffset(72)] [XdbElement] public AsciiString BinaryFile;
        [MemoryOffset(32)] [XdbElement("sourceFileCRC")]  public Int SourceFileCrc;
        [MemoryArrayOffset(84,24)] [XdbArray] public AnimationEvent[] AnimationEvents;
        [MemoryOffset(24)] [XdbElement] public Int StartFrame; //TODO: Verify
        [MemoryOffset(60)] [XdbElement] public Int EndFrame;
        [MemoryOffset(56)] [XdbElement] public Float Fps;
        [MemoryOffset(36)] [XdbElement] public AsciiString ScriptName;
        [MemoryOffset(48)] [XdbElement("scriptID")]
        public Int ScriptId;

        [MemoryOffset(64)] [XdbElement] public Float BlendTime;
        [MemoryOffset(52)] [XdbElement] public Bool Looped;
        [MemoryOffset(28)] [XdbElement] public Float Speed;
        [MemoryOffset(68)] [XdbElement] public Int BinaryVersion;
        [MemoryOffset(136)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(112)] [XdbElement] public Aabb AabbLastFrame;
        
        
        public class AnimationEvent : Resource
        {
            [MemoryOffset(4)] [XdbElement] public AsciiString Name;
            [MemoryOffset(16)] [XdbElement] public Int Id;
            [MemoryOffset(20)] [XdbElement] public Float Event;
        }
    }
}