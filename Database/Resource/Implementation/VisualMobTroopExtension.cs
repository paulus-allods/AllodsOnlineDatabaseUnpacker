using Database.DataType.Implementation;
using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class VisualMobTroopExtension : VisualMobExtension
    {
        [MemoryArrayOffset(24, 92)] [XdbArray] public Member[] Members;

        public class Member : Resource
        {
            [MemoryOffset(84)] [XdbElement] public FileRef Character;
            [MemoryOffset(8)] [XdbElement] public CharacterVariation Variation;
        }
    }
}