using Database.Serialization.Memory;
using Database.Serialization.XDB;

namespace Database.Resource.Implementation
{
    public class TexturePatch : Resource
    {
        [MemoryArrayOffset(56, 32)] [XdbArray] public TextureRect[] Female;
        [MemoryArrayOffset(40, 32)] [XdbArray] public TextureRect[] Male;
        [MemoryArrayOffset(24, 32)] [XdbArray] public TextureRect[] Unisex;
    }
}