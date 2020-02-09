using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class Control : Resource
    {
        [MemoryArrayOffset(16, 28)] [XdbArray] public BoneTransform[] Bones;
        [MemoryOffset(12)] [XdbEnum(typeof(ModelMorphControl))] public Int ControlName;
        [MemoryOffset(8)] [XdbElement] public Float MaxVal;
        [MemoryOffset(4)] [XdbElement] public Float MinVal;
    }
}