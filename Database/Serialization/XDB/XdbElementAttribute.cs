using System;
using System.Reflection;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Database.Serialization.XDB
{
    [MeansImplicitUse]
    [AttributeUsage(AttributeTargets.Field)]
    public class XdbElementAttribute : Attribute
    {
        protected readonly string Name;

        public XdbElementAttribute(string name = null)
        {
            Name = name;
        }

        public virtual XElement SerializeField([NotNull] FieldInfo field, object obj)
        {
            if (!(field.GetValue(obj) is IXdbSerializable fieldValue))
                throw new Exception("Cannot serialize field");
            var fieldName = field.Name;
            fieldName = char.ToLowerInvariant(fieldName[0]) + fieldName.Substring(1);
            return fieldValue.Serialize(Name ?? fieldName);
        }
    }
}