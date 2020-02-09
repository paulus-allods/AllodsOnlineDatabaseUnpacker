using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetButtonState : Resource
    {
        [MemoryOffset(16)] [XdbElement("FormatFileRef")] public TextFileRef FormatFileRef;
        [MemoryOffset(8)] [XdbElement("LayerMain")] public FileRef LayerMain;
    }
}