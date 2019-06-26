using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Texture : Resource
    {
        [MemoryOffset(88)] [XdbElement] public Bool AlphaTex;
        [MemoryOffset(76)] [XdbElement] public TextFileRef BinaryFile;

        [MemoryOffset(73)] [XdbElement("disableLODControl")]
        public Bool DisableLodControl;

        [MemoryOffset(72)] [XdbElement] public Bool GenerateMipChain;
        [MemoryOffset(68)] [XdbElement] public Int Height;
        [MemoryOffset(60)] [XdbElement] public Int MipsNumber;

        [MemoryOffset(64)] [XdbElement("mipSW")]
        public Int MipSw;

        [MemoryOffset(56)] [XdbElement] public Int RealHeight;
        [MemoryOffset(52)] [XdbElement] public Int RealWidth;
        [MemoryOffset(40)] [XdbElement] public TextFileRef SourceFile;

        [MemoryOffset(36)] [XdbElement("sourceFileCRC")]
        public Int SourceFileCrc;

        [MemoryOffset(32)] [XdbEnum(typeof(TextureElementType))]
        public Int Type;

        [MemoryOffset(28)] [XdbElement] public Int Width;
        [MemoryOffset(24)] [XdbElement] public Bool Wrap;
    }
}