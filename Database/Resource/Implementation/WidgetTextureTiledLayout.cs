using System.Configuration.Provider;
using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetTextureTiledLayout : Resource
    {
        [MemoryOffset(20)] [XdbElement("LeftX")] public Int LeftX;
        [MemoryOffset(16)] [XdbElement("MiddleX")] public Int MiddleX;
        [MemoryOffset(8)] [XdbElement("RightX")] public Int RightX;
        [MemoryOffset(4)] [XdbElement("TopY")] public Int TopY;
        [MemoryOffset(12)] [XdbElement("MiddleY")] public Int MiddleY;
        [MemoryOffset(24)] [XdbElement("BottomY")] public Int BottomY;
    }
}