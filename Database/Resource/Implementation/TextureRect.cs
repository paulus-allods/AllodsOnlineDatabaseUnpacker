using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TextureRect : Resource
    {
        [MemoryOffset(4)] [XdbElement] public FileRef Texture;
        [MemoryOffset(12)] [XdbElement] public Rect Rectangle;
        
        public class Rect : Resource
        {
            [MemoryOffset(16)] [XdbElement] public Float X1;
            [MemoryOffset(8)] [XdbElement] public Float Y1;
            [MemoryOffset(12)] [XdbElement] public Float X2;
            [MemoryOffset(4)] [XdbElement] public Float Y2;
        }

    }
}