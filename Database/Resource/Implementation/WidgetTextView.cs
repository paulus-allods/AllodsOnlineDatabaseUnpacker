using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetTextView : Widget
    {
        [MemoryOffset(304)] [XdbElement("FormatFileRef")] public TextFileRef FormatFileRef;
        [MemoryArrayOffset(268,32)] [XdbArray("TextValues")] public WidgetTextTaggedValue[] TextValues;

        [MemoryOffset(320)] [XdbElement("DefaultTag")]
        public AsciiString DefaultTag;
        
        [MemoryOffset(284)] [XdbElement("TextStyle")] public WidgetTextStyle TextStyle;
        [MemoryOffset(260)] [XdbElement] public Float MinWidth;
        [MemoryOffset(264)] [XdbElement] public Float MaxWidth;
        //TODO: [MemoryOffset()] [XdbElement] public Bool PickObjectsOnly;
    }
}