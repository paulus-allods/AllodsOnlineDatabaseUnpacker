using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetButton : Widget
    {
        [MemoryOffset(304)] [XdbElement("TextStyle")]
        public WidgetTextStyle TextStyle;

        [MemoryOffset(292)] [XdbElement("TextTag")]
        public AsciiString TextTag;

        [MemoryOffset(256)] [XdbElement] public Bool UseDefaultSounds;

        //TODO: [MemoryArrayOffset()] [XdbArray] public BindSection[] PushingBindSections;
        [MemoryArrayOffset(276, 244)] [XdbArray("Variants")]
        public WidgetButtonVariant[] Variants;
    }
}