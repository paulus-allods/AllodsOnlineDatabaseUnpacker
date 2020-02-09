using Database.DataType.Implementation;
using Database.Resource.Enum;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetLayer : Resource
    {
        [MemoryOffset(32)] [XdbEnum(typeof(BlendEffectType), "BlendEffect")] public Int BlendEffect;
        [MemoryOffset(28)] [XdbElement("Color")] public Int Color;
        [MemoryOffset(25)] [XdbElement] public Bool FlatPlacement;
        [MemoryOffset(26)] [XdbElement("Grayed")] public Bool Grayed;
        [MemoryOffset(24)] [XdbElement] public Bool LazyLoad;
    }
}