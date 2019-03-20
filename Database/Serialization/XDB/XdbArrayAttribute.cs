using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Database.Serialization.XDB
{
    public class XdbArrayAttribute : XdbElementAttribute
    {
        private readonly string _itemName;

        public XdbArrayAttribute(string name = null, string itemName = "Item") : base(name)
        {
            _itemName = itemName;
        }

        public override XElement SerializeField(FieldInfo field, object obj)
        {
            var root = new XElement(Name ?? field.Name.ToLower());
            if (!(field.GetValue(obj) is IEnumerable<IXdbSerializable> fieldArray))
                throw new Exception("Cannot serialize field");
            foreach (var fieldEntry in fieldArray) root.Add(fieldEntry.Serialize(_itemName));
            return root;
        }
    }
}