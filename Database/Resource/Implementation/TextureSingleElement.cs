using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TextureSingleElement
    {
        [MemoryOffset(56)] [XdbElement] public FileRef Atlas;
        [MemoryOffset(52)] [XdbElement] public Int Crc;
        [MemoryOffset(48)] [XdbElement] public Int Height;
        [MemoryOffset(36)] [XdbElement] public TextFileRef SourceFile;
        [MemoryOffset(32)] [XdbElement] public Int Width;
        [MemoryOffset(28)] [XdbElement] public Int X;
        [MemoryOffset(24)] [XdbElement] public Int Y;
    }
}