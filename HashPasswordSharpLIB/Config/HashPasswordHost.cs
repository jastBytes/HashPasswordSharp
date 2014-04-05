using System.Collections.Generic;
using System.Xml.Serialization;

namespace de.janbusch.HashPasswordSharp.lib.Config
{
    [XmlRoot(ElementName = "Host")]
    public class HashPasswordHost
    {
        [XmlAttribute]
        public string HashType { get; set; }

        [XmlAttribute]
        public string Charset { get; set; }

        [XmlAttribute]
        public string PasswordLength { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string LastLogin { get; set; }

        [XmlElement(IsNullable = true)]
        public HashPasswordLoginNames LoginNames { get; set; }
    }

    [XmlRoot(ElementName = "LoginNames")]
    public class HashPasswordLoginNames
    {
        [XmlElement(IsNullable = true)]
        public List<HashPasswordLogin> LoginName { get; set; }
    }
}
