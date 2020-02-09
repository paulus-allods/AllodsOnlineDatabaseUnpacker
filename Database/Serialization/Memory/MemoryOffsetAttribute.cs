using System;
using System.Reflection;
using JetBrains.Annotations;
using NLog;

namespace Database.Serialization.Memory
{
    [AttributeUsage(AttributeTargets.Field)]
    public class MemoryOffsetAttribute : Attribute
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        protected readonly int Offset;

        public MemoryOffsetAttribute(int offset)
        {
            Offset = offset;
        }

        public virtual void DeserializeField([NotNull] FieldInfo field, IntPtr memoryAddress, object obj)
        {
            Logger.Debug($"Deserializing {field.Name} at {(memoryAddress + Offset).ToString("x8")}");
            if (typeof(IMemoryDeserializable).IsAssignableFrom(field.FieldType))
            {
                var fieldValue = (IMemoryDeserializable) Activator.CreateInstance(field.FieldType);
                fieldValue.Deserialize(memoryAddress + Offset);
                field.SetValue(obj, fieldValue);
            }
            else
            {
                throw new Exception("Cannot deserialize field");
            }
        }
    }
}