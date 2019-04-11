using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetLayerSimpleTexture : WidgetLayer
    {
        [MemoryOffset(48)] [XdbElement] public FileRef TextureItem;
        [MemoryOffset(40)] [XdbElement] public FileRef TextureMask;
        [MemoryOffset(56)] [XdbElement("Scaling")] public Bool Scaling;
    }
}