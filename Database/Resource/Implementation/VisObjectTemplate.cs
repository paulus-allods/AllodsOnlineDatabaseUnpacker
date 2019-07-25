using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VisObjectTemplate : Resource
    {
        [MemoryOffset(112)] [XdbElement] public VisObjState DefaultState;
        [MemoryOffset(108)] [XdbElement("fadeInMS")] public Int FadeInMs;
        [MemoryOffset(104)] [XdbElement("fadeOutMS")] public Int FadeOutMs;
        [MemoryOffset(96)] [XdbElement] public FileRef Geometry;

        //TODO: [MemoryArrayOffset(24,)] [XdbArray] public GenericField<VisualObjectComponent>[] VisObjComponents;
        [MemoryOffset(88)] [XdbElement] public FileRef Particle;
        [MemoryOffset(84)] [XdbElement] public Float Scale;
        [MemoryOffset(60)] [XdbElement] public Sound3D Sound;
        [MemoryOffset(56)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        [MemoryArrayOffset(40, 52)] [XdbArray] public VisObjState[] States;

        public class VisObjState : Resource
        {
            [MemoryOffset(44)] [XdbElement] public FileRef Animation;
            [MemoryArrayOffset(28, 24)] [XdbArray] public AttachedObject[] Objects;
            [MemoryOffset(4)] [XdbElement] public Sound3D Sound;

            public class AttachedObject : Resource
            {
                [MemoryOffset(12)] [XdbElement] public AsciiString LocatorName;
                [MemoryOffset(4)] [XdbElement] public FileRef VisObject;
            }
        }
    }
}