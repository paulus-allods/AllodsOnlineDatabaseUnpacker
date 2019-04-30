using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class AmbientCoefficients : Resource
    {
        [MemoryOffset(20)] [XdbElement] public Float B;
        [MemoryOffset(16)] [XdbElement] public Float G;
        [MemoryOffset(12)] [XdbElement] public Float R;
        [MemoryOffset(8)] [XdbElement] public Bool Use;
        [MemoryOffset(4)] [XdbElement] public Float W;
    }
}