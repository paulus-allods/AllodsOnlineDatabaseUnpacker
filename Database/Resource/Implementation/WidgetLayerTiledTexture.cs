using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetLayerTiledTexture : WidgetLayer
    {
        [MemoryOffset(48)] [XdbElement("Layout")]
        public WidgetTextureTiledLayout Layout;

        [MemoryOffset(40)] [XdbElement] public FileRef TextureItem;
    }
}