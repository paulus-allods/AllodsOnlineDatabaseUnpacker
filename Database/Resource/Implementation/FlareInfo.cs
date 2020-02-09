using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class FlareInfo : Resource
    {
        [MemoryOffset(16)] [XdbElement] public FileRef FlareEffect;
        [MemoryOffset(4)] [XdbElement] public AsciiString LocatorName;
    }
}