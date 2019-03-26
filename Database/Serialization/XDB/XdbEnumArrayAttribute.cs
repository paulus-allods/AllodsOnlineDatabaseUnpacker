using System;
using System.Reflection;
using System.Xml.Linq;
using Database.DataType.Implementation;

namespace Database.Serialization.XDB
{
    public class XdbEnumArrayAttribute : XdbElementAttribute
    {
        private readonly Type _enumType;
        private readonly string _itemName;

        public XdbEnumArrayAttribute(Type enumType, string name = null, string itemName = "Item") : base(name)
        {
            _enumType = enumType;
            _itemName = itemName;
        }

        public override XElement SerializeField(FieldInfo field, object obj)
        {
            var root = new XElement(Name ?? field.Name.ToLower());
            if (!(field.GetValue(obj) is Int[] fieldArray))
                throw new Exception("Cannot cast non int array to enum array");
            foreach (var fieldEntry in fieldArray)
            {
                var asciiString = new AsciiString(Enum.GetName(_enumType, (int) fieldEntry));
                root.Add(asciiString.Serialize(_itemName));
            }

            return root;
        }
    }
}