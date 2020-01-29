using System;
using System.Reflection;
using System.Xml.Linq;
using Database.DataType.Implementation;

namespace Database.Serialization.XDB
{
    public class XdbEnumArrayAttribute : XdbElementAttribute
    {
        private readonly Type enumType;
        private readonly string itemName;

        public XdbEnumArrayAttribute(Type enumType, string name = null, string itemName = "Item") : base(name)
        {
            this.enumType = enumType;
            this.itemName = itemName;
        }

        public override XElement SerializeField(FieldInfo field, object obj)
        {
            var fieldName = field.Name;
            fieldName = char.ToLowerInvariant(fieldName[0]) + fieldName.Substring(1);
            var root = new XElement(Name ?? fieldName);
            if (!(field.GetValue(obj) is Int[] fieldArray))
                throw new Exception("Cannot cast non int array to enum array");
            foreach (var fieldEntry in fieldArray)
            {
                var enumValue = Enum.GetName(enumType, (int) fieldEntry);
                var asciiString = new AsciiString(enumValue);
                Logger.Debug($"Enum value for {fieldName} of {obj.GetType()}: {enumValue} (Type:{enumType},Ordinal:{(int) fieldEntry}");
                root.Add(asciiString.Serialize(itemName));
            }

            return root;
        }
    }
}