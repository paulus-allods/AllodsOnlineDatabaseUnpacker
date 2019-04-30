using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VisObjectTemplate : Resource
    {
        [MemoryOffset(108)] [XdbElement("fadeInMS")] public Int FadeInMs;
        [MemoryOffset(104)] [XdbElement("fadeOutMS")] public Int FadeOutMs;
        [MemoryOffset(112)] [XdbElement] public VisObjState DefaultState;
        [MemoryArrayOffset(40,52)] [XdbArray] public VisObjState[] States;
        //TODO: [MemoryArrayOffset(24,)] [XdbArray] public GenericField<VisualObjectComponent>[] VisObjComponents;
        [MemoryOffset(88)] [XdbElement] public FileRef Particle;
        [MemoryOffset(96)] [XdbElement] public FileRef Geometry;
        [MemoryOffset(60)] [XdbElement] public Sound3D Sound;
        [MemoryOffset(84)] [XdbElement] public Float Scale;
        [MemoryOffset(56)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        
        public class VisObjState : Resource
        {
            [MemoryOffset(4)] [XdbElement] public Sound3D Sound;
            [MemoryArrayOffset(28,24)] [XdbArray] public AttachedObject[] Objects;
            [MemoryOffset(44)] [XdbElement] public FileRef Animation;
            
            public class AttachedObject : Resource
            {
                [MemoryOffset(4)] [XdbElement] public FileRef VisObject;
                [MemoryOffset(12)] [XdbElement] public AsciiString LocatorName;
            }
        }
    }
}