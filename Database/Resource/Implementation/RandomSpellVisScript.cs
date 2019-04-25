using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class RandomSpellVisScript : Resource
    {
        [MemoryOffset(4)] [XdbElement] public FileRef Script;
        [MemoryOffset(12)] [XdbElement] public Int Rate;
    }
}