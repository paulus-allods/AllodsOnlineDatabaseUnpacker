using System.Xml.Linq;

namespace Database.Serialization.XDB
{
    public interface IXdbSerializable
    {
        XElement Serialize(string name);
    }
}