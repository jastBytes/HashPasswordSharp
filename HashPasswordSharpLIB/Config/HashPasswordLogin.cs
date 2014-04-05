using System.Xml.Serialization;

namespace de.janbusch.HashPasswordSharp.lib.Config
{
    [XmlRoot(ElementName = "LoginName")]
    public class HashPasswordLogin
    {
        [XmlElement(IsNullable = false)]
        public string HashType { get; set; }

        [XmlElement(IsNullable = false)]
        public string Charset { get; set; }

        [XmlElement(IsNullable = false)]
        public string PasswordLength { get; set; }

        [XmlElement(IsNullable = false)]
        public string Name { get; set; }
    }
}
