using System;
using System.Reflection;
using System.Xml.Linq;
using Database.DataType.Implementation;

namespace Database.Serialization.XDB
{
    public class XdbEnumAttribute : XdbElementAttribute
    {
        private readonly Type _enumType;

        public XdbEnumAttribute(Type enumType, string name = null) : base(name)
        {
            _enumType = enumType;
        }

        public override XElement SerializeField(FieldInfo field, object obj)
        {
            if (!(field.GetValue(obj) is Int intValue))
                throw new Exception("Cannot cast non int to enum");
            var fieldName = field.Name;
            fieldName = char.ToLowerInvariant(fieldName[0]) + fieldName.Substring(1);
            var asciiString = new AsciiString(Enum.GetName(_enumType, (int) intValue));
            return asciiString.Serialize(Name ?? fieldName);
        }
    }
}