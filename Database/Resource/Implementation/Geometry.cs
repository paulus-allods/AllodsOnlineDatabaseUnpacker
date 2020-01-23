using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Geometry : Resource
    {
        [MemoryOffset(368)] [XdbElement] public Aabb Aabb;
        [MemoryArrayOffset(352, 96)] [XdbArray] public KDTreeAreaFragment[] AreaFragments;
        [MemoryOffset(340)] [XdbElement] public TextFileRef BinaryFile;
        [MemoryOffset(338)] [XdbElement] public Bool CastShadows;
        [MemoryOffset(337)] [XdbElement] public Bool DecalModel;
        [MemoryOffset(336)] [XdbElement] public Bool EnableDistanceFade;
        [MemoryOffset(332)] [XdbElement] public Int EndFrame;
        [MemoryOffset(328)] [XdbElement] public Bool ExportDefaultAnimation;
        [MemoryOffset(324)] [XdbElement] public Float FadeDistanceEnd;
        [MemoryOffset(320)] [XdbElement] public Float FadeDistanceStart;
        [MemoryArrayOffset(304, 20)] [XdbArray] public FlareInfo[] FlareInfos;
        [MemoryOffset(300)] [XdbElement] public Float FogFactor;
        [MemoryOffset(276)] [XdbElement] public Aabb GeometryBox;
        [MemoryArrayOffset(260, 40)] [XdbArray] public KDTreeGeometryFragment[] GeometryFragments;
        [MemoryOffset(256)] [XdbElement("globalID")] public Int GlobalId;
        [MemoryOffset(252)] [XdbElement] public Bool IgnoreZ;
        [MemoryOffset(240)] [XdbElement] public Blob IndexBuffer;
        [MemoryArrayOffset(224, 20)] [XdbArray] public NamedJoint[] Joints;
        [MemoryOffset(120)] [XdbElement] public Bool LargeModel;
        [MemoryArrayOffset(204, 4)] [XdbArray] public Float[] LodDistances;
        [MemoryOffset(200)] [XdbElement] public Float LodFactor;
        [MemoryOffset(196)] [XdbElement] public Bool LodModel;
        [MemoryArrayOffset(180, 112)] [XdbArray] public ModelElement[] ModelElements;
        [MemoryArrayOffset(164, 60)] [XdbArray] public OccluderInfo[] OccluderInfos;
        [MemoryOffset(160)] [XdbElement] public Bool OptimizeMesh;
        [MemoryOffset(156)] [XdbEnum(typeof(OrientationMode))] public Int OrientationMode;
        [MemoryArrayOffset(140, 68)] [XdbArray] public ModelPart[] Parts;
        [MemoryArrayOffset(124, 76)] [XdbArray] public KDTreePortalFragment[] PortalFragments;
        [MemoryOffset(220)] [XdbElement] public Bool PortalModel;
        [MemoryOffset(116)] [XdbElement] public Int RealSkeletonSize;
        [MemoryOffset(112)] [XdbElement] public GenericField<MaterialParams> RootMaterial;
        [MemoryOffset(108)] [XdbElement] public Float ScaleDistanceEnd;
        [MemoryOffset(104)] [XdbElement] public Float ScaleDistanceStart;
        [MemoryArrayOffset(88, 48)] [XdbArray] public NamedNode[] SceneNodes;
        [MemoryOffset(392)] [XdbElement("SkeletalAnimation")] public FileRef SkeletalAnimation;
        [MemoryOffset(76)] [XdbElement] public Blob Skeleton;
        [MemoryOffset(72)] [XdbEnum(typeof(SortMode))] public Int SortMode;
        [MemoryOffset(68)] [XdbElement("sourceFileCRC")] public Int SourceFileCrc;
        [MemoryOffset(64)] [XdbElement] public Int StartFrame;
        [MemoryOffset(63)] [XdbElement] public Bool UseColors;
        [MemoryOffset(62)] [XdbElement] public Bool UseDecals;
        [MemoryOffset(61)] [XdbElement] public Bool UseProceduralEffect;
        [MemoryOffset(60)] [XdbElement] public Bool Vb32;
        [MemoryOffset(56)] [XdbElement] public Int Version;
        [MemoryOffset(44)] [XdbElement] public Blob VertexBuffer;
        [MemoryArrayOffset(28, 92)] [XdbArray] public VertexDeclaration[] VertexDeclarations;
        [MemoryOffset(24)] [XdbElement] public Int VisualSkeletonSize;
    }
}