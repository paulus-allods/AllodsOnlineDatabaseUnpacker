using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ControlValue
    {
        [MemoryOffset(8)] [XdbEnum(typeof(ModelMorphControl))]
        public Int ControlName;

        [MemoryOffset(4)] [XdbElement] public Float Value;
    }
}