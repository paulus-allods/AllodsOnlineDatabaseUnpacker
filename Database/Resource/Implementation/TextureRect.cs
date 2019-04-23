using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TextureRect : Resource
    {
        [MemoryOffset(12)] [XdbElement] public Rect Rectangle;
        [MemoryOffset(4)] [XdbElement] public FileRef Texture;

        public class Rect : Resource
        {
            [MemoryOffset(16)] [XdbElement] public Float X1;
            [MemoryOffset(12)] [XdbElement] public Float X2;
            [MemoryOffset(8)] [XdbElement] public Float Y1;
            [MemoryOffset(4)] [XdbElement] public Float Y2;
        }
    }
}