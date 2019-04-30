using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetPlacement : Resource
    {
        [MemoryOffset(20)] [XdbEnum(typeof(WidgetAlign), "Align")]
        public Int Align;

        [MemoryOffset(16)] [XdbElement("HighPos")]
        public Float HighPos;

        [MemoryOffset(12)] [XdbElement("Pos")] public Float Pos;
        [MemoryOffset(8)] [XdbElement("Size")] public Float Size;

        [MemoryOffset(4)] [XdbEnum(typeof(WidgetSizing), "Sizing")]
        public Int Sizing;
    }
}