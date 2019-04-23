using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class UiTextureItem : Resource
    {
        [MemoryOffset(32)] [XdbElement] public FileRef SingleTexture;

        [MemoryOffset(24)] [XdbElement] public FileRef TextureElement;
        //TODO: [MemoryOffset()] [XdbElement] public Int PermanentCache;
    }
}