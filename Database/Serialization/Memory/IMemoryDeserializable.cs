using System;

namespace Database.Serialization.Memory
{
    public interface IMemoryDeserializable
    {
        void Deserialize(IntPtr memoryAddress);
    }
}