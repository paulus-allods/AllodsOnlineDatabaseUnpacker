using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class CollisionMesh : Resource
    {
        [MemoryOffset(72)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(60)] [XdbElement] public TextFileRef BinaryFile;
        [MemoryOffset(56)] [XdbElement] public Int BinaryVersion;
        [MemoryOffset(52)] [XdbElement] public Int ClipMask;
        [MemoryArrayOffset(36, 8)] [XdbArray] public FileRef[] CustomMaterials;
        [MemoryOffset(28)] [XdbElement] public FileRef DefaultMaterial;
        [MemoryOffset(24)] [XdbElement("SourceFileCRC")] public Int SourceFileCrc;
    }
}