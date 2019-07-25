using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Widget : Resource
    {
        [MemoryOffset(244)] [XdbElement("BackLayer")] public FileRef BackLayer;
        [MemoryArrayOffset(88, 32)] [XdbArray] public BindSection[] BindSections;
        [MemoryArrayOffset(228, 8)] [XdbArray("Children")] public FileRef[] Children;
        [MemoryOffset(84)] [XdbElement] public Bool ClipContent;
        [MemoryOffset(224)] [XdbElement("Enabled")] public Bool Enabled;
        [MemoryOffset(80)] [XdbElement] public Float Fade;
        [MemoryOffset(68)] [XdbElement] public AsciiString ForceReactionOnPointing;
        [MemoryOffset(216)] [XdbElement("FrontLayer")] public FileRef FrontLayer;
        [MemoryOffset(212)] [XdbElement("IgnoreDblClick")] public Bool IgnoreDblClick;
        [MemoryOffset(200)] [XdbElement("Name")] public AsciiString Name;
        [MemoryOffset(196)] [XdbElement("PickChildrenOnly")] public Bool PickChildrenOnly;
        [MemoryOffset(60)] [XdbElement] public FileRef PickMask;
        [MemoryOffset(116)] [XdbElement("Placement")] public WidgetPlacementXY Placement;
        [MemoryOffset(112)] [XdbElement("Priority")] public Int Priority;
        [MemoryOffset(48)] [XdbElement] public AsciiString ReactionOnPointing;
        [MemoryOffset(40)] [XdbElement] public FileRef SoundHide;
        [MemoryOffset(32)] [XdbElement] public FileRef SoundShow;
        [MemoryOffset(108)] [XdbElement("TabOrder")] public Int TabOrder;
        [MemoryOffset(24)] [XdbElement] public FileRef TextureMask;
        [MemoryOffset(105)] [XdbElement("TransparentInput")] public Bool TransparentInput;
        [MemoryOffset(104)] [XdbElement("Visible")] public Bool Visible;

        public class BindSection : Resource
        {
            [MemoryArrayOffset(4, 12)] [XdbArray] public AsciiString[] BindedReactions;
            [MemoryOffset(20)] [XdbElement("bindSection")] public AsciiString MBindSection;
        }
    }
}