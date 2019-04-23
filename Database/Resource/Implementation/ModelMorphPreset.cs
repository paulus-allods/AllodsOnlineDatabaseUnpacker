using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ModelMorphPreset : Resource
    {
        [MemoryArrayOffset(8, 16)] [XdbArray] public ControlValue[] Values;
    }
}