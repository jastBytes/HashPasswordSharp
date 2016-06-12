using System.Xml.Serialization;

namespace JaSt.HashPasswordSharp.Library.Config
{
    [XmlRoot(ElementName = "LoginName")]
    public class HashPasswordLogin
    {
        [XmlAttribute]
        public string HashType { get; set; }

        [XmlAttribute]
        public string Charset { get; set; }

        [XmlAttribute]
        public string PasswordLength { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
    }
}
