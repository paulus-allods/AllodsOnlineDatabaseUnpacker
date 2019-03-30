using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class CollisionMesh
    {
        [MemoryOffset(60)] [XdbElement] public FileRef BinaryFile;
        [MemoryOffset(72)] [XdbElement] public Aabb Aabb;
        [MemoryOffset(56)] [XdbElement] public Int BinaryVersion;
        //TODO: [MemoryOffset()] [XdbElement] public FileRef DefaultMaterial;
        //TODO: [MemoryArrayOffset()] [XdbArray] public FileRef[] CustomMaterials;
        [MemoryOffset(52)] [XdbElement] public Int ClipMask;
        [MemoryOffset(24)] [XdbElement("SourceFileCRC")] public Int SourceFileCrc;
    }
}