using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class SpecialShuffleParams : Resource
    {
        [MemoryOffset(4)] [XdbElement] public Float MinChangeRotationAngle;
        [MemoryOffset(0)] [XdbElement] public Float MinChangeVelocityAngle;
    }
}