using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TextureAtlas : Resource
    {
        [MemoryArrayOffset(24,48)] [XdbArray] public Source[] Sources;
        [MemoryOffset(40)] [XdbElement] public FileRef CombinedTexture;
        
        public class Source : Resource
        {
            [MemoryOffset(32)] [XdbElement] public AsciiString Name;
            [MemoryOffset(28)] [XdbElement] public Int Width;
            [MemoryOffset(44)] [XdbElement] public Int Height;
            [MemoryOffset(24)] [XdbElement] public Int X;
            [MemoryOffset(12)] [XdbElement] public Int Y;
            [MemoryOffset(16)] [XdbElement("xCoeffRGB")] public Float XCoeffRgb;
            [MemoryOffset(4)] [XdbElement("yCoeffRGB")] public Float YCoeffRgb;
            [MemoryOffset(20)] [XdbElement] public Float XCoeffA;
            [MemoryOffset(8)] [XdbElement] public Float YCoeffA;
        }
    }
}