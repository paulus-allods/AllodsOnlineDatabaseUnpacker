using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ModelMorphPreset : Resource
    {
        [MemoryArrayOffset(8, 16)] [XdbElement]
        public ControlValue[] Values;
    }
}