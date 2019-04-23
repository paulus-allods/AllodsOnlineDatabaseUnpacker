using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class ModelMorphSettings : Resource
    {
        [MemoryArrayOffset(40, 32)] [XdbArray] public Control[] Controls;
        [MemoryArrayOffset(24, 24)] [XdbArray] public ModelMorphPreset[] Presets;
    }
}