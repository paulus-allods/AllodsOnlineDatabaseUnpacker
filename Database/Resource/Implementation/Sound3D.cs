using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Sound3D : Resource
    {
        [MemoryOffset(12)] [XdbElement] public AsciiString Name;
        [MemoryOffset(4)] [XdbElement] public FileRef Project;
    }
}