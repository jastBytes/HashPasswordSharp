using System.Xml.Serialization;

namespace de.janbusch.HashPasswordSharp.lib.Config
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
