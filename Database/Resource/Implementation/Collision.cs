using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Collision : Resource
    {
        [MemoryOffset(28)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        [MemoryOffset(24)] [XdbEnum(typeof(CollisionVolume))] public Int Volume;
        [MemoryOffset(44)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(32)] [XdbElement] public FileRef CollisionMesh;
    }
}