using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetTextView : Widget
    {
        [MemoryOffset(320)] [XdbElement("DefaultTag")] public AsciiString DefaultTag;
        [MemoryOffset(304)] [XdbElement("FormatFileRef")] public TextFileRef FormatFileRef;
        [MemoryOffset(264)] [XdbElement] public Float MaxWidth;
        [MemoryOffset(260)] [XdbElement] public Float MinWidth;
        [MemoryOffset(284)] [XdbElement("TextStyle")] public WidgetTextStyle TextStyle;
        [MemoryArrayOffset(268, 32)] [XdbArray("TextValues")] public WidgetTextTaggedValue[] TextValues;

        //TODO: [MemoryOffset()] [XdbElement] public Bool PickObjectsOnly;
    }
}