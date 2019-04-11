using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Texture : Resource
    {
        [MemoryOffset(64)] [XdbElement("mipSW")] public Int MipSw;
        [MemoryOffset(60)] [XdbElement] public Int MipsNumber;
        [MemoryOffset(72)] [XdbElement] public Bool GenerateMipChain;
        [MemoryOffset(32)] [XdbEnum(typeof(TextureElementType))] public Int Type;
        [MemoryOffset(28)] [XdbElement] public Int Width;
        [MemoryOffset(68)] [XdbElement] public Int Height;
        [MemoryOffset(52)] [XdbElement] public Int RealWidth;
        [MemoryOffset(56)] [XdbElement] public Int RealHeight;
        [MemoryOffset(73)] [XdbElement("disableLODControl")] public Bool DisableLodControl;
        [MemoryOffset(88)] [XdbElement] public Bool AlphaTex;
        [MemoryOffset(76)] [XdbElement] public AsciiString BinaryFile;
        [MemoryOffset(40)] [XdbElement] public AsciiString SourceFile;
        [MemoryOffset(36)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        [MemoryOffset(24)] [XdbElement] public Bool Wrap;
    }
}