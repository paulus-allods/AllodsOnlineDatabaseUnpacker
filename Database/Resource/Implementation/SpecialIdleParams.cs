using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class SpecialIdleParams : Resource
    {
        [MemoryOffset(20)] [XdbElement] public Int BeforeStartMax;
        [MemoryOffset(16)] [XdbElement] public Int BeforeStartMin;
        [MemoryOffset(12)] [XdbElement] public Int MinTimeAfterIdleJStarts;
        [MemoryOffset(8)] [XdbElement] public Int PeriodMax;
        [MemoryOffset(4)] [XdbElement] public Int PeriodMin;
    }
}