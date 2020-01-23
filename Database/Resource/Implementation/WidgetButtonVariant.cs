using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetButtonVariant : Resource
    {
        [MemoryOffset(236)] [XdbElement("LayerHighlight")] public FileRef LayerHighLight;
        [MemoryOffset(228)] [XdbElement("PushedOffset")] public Vector2 PushedOffset;
        [MemoryOffset(216)] [XdbElement("Reaction")] public AsciiString Reaction;
        [MemoryOffset(20)] [XdbElement] public AsciiString ReactionDblClick;
        [MemoryOffset(204)] [XdbElement("ReactionOnPointing")] public AsciiString ReactionOnPointing;
        [MemoryOffset(200)] [XdbElement("ReactionOnUp")] public Bool ReactionOnUp;
        [MemoryOffset(188)] [XdbElement("ReactionRightClick")] public AsciiString ReactionRightClick;
        [MemoryOffset(12)] [XdbElement] public FileRef SoundOver;
        [MemoryOffset(4)] [XdbElement] public FileRef SoundPress;
        [MemoryOffset(156)] [XdbElement("StateDisabled")] public WidgetButtonState StateDisabled;
        [MemoryOffset(128)] [XdbElement("StateHighlighted")] public WidgetButtonState StateHighlighted;
        [MemoryOffset(100)] [XdbElement("StateNormal")] public WidgetButtonState StateNormal;
        [MemoryOffset(72)] [XdbElement("StatePushed")] public WidgetButtonState StatePushed;
        [MemoryOffset(44)] [XdbElement("StatePushedHighlighted")] public WidgetButtonState StatePushedHighlighted;
        [MemoryOffset(32)] [XdbElement("TextFileRef")] public TextFileRef TextFileRef;
    }
}