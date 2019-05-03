using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class WidgetPlacementXY : Resource
    {
        [MemoryOffset(76)] [XdbElement("QuantumScale")]
        public Bool QuantumScale;

        [MemoryOffset(20)] [XdbElement] public FileRef SizingWidget;
        [MemoryArrayOffset(4, 8)] [XdbArray] public FileRef[] SizingWidgets;
        [MemoryOffset(52)] [XdbElement("X")] public WidgetPlacement X;
        [MemoryOffset(28)] [XdbElement("Y")] public WidgetPlacement Y;
    }
}