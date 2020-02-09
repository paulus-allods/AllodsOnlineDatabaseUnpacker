using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetTextTaggedValue : Resource
    {
        [MemoryOffset(20)] [XdbElement("Tag")] public AsciiString Tag;
        [MemoryOffset(4)] [XdbElement("TagValueFileRef")] public TextFileRef TagValueFileRef;
    }
}