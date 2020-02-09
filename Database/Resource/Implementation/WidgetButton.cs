using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetButton : Widget
    {
        [MemoryArrayOffset(260, 32)] [XdbArray] public BindSection[] PushingBindSections;
        [MemoryOffset(304)] [XdbElement("TextStyle")] public WidgetTextStyle TextStyle;
        [MemoryOffset(292)] [XdbElement("TextTag")] public AsciiString TextTag;
        [MemoryOffset(256)] [XdbElement] public Bool UseDefaultSounds;
        [MemoryArrayOffset(276, 244)] [XdbArray("Variants")] public WidgetButtonVariant[] Variants;
    }
}