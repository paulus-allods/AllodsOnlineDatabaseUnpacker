using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class UITextureItem : Resource
    {
        [MemoryOffset(40)] [XdbElement] public Int PermanentCache;
        [MemoryOffset(32)] [XdbElement] public FileRef SingleTexture;
        [MemoryOffset(24)] [XdbElement] public FileRef TextureElement;
    }
}