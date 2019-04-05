using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ControlValue : Resource
    {
        [MemoryOffset(12)] [XdbEnum(typeof(ModelMorphControl))]
        public Int ControlName;

        [MemoryOffset(8)] [XdbElement] public Float Value;
    }
}