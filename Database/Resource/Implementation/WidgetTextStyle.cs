using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetTextStyle : Resource
    {
        [MemoryOffset(16)] [XdbEnum(typeof(AlignY), "Align")]
        public Int Align;

        [MemoryOffset(12)] [XdbElement] public Bool Ellipsis;
        [MemoryOffset(8)] [XdbElement] public Float LineSpacing;
        [MemoryOffset(7)] [XdbElement] public Bool Multiline;
        [MemoryOffset(6)] [XdbElement] public Bool ShowClippedLine;
        [MemoryOffset(5)] [XdbElement] public Bool ShowClippedSymbol;
        [MemoryOffset(4)] [XdbElement] public Bool WrapText;

        private enum AlignY
        {
            ALIGNY_DEFAULT,
            ALIGNY_TOP,
            ALIGNY_MIDDLE,
            ALIGNY_BOTTOM
        }
    }
}