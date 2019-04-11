using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetLayerTiledTexture : WidgetLayer
    {
        [MemoryOffset(40)] [XdbElement] public FileRef TextureItem;

        [MemoryOffset(48)] [XdbElement("Layout")]
        public WidgetTextureTiledLayout Layout;
    }
}