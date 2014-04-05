using System.Collections.Generic;
using System.Xml.Serialization;

namespace de.janbusch.HashPasswordSharp.lib.Config
{
    [XmlRoot(ElementName = "Host")]
    public class HashPasswordHost
    {
        [XmlElement(IsNullable = false)]
        public string HashType { get; set; }

        [XmlElement(IsNullable = false)]
        public string Charset { get; set; }

        [XmlElement(IsNullable = false)]
        public string PasswordLength { get; set; }

        [XmlElement(IsNullable = false)]
        public string Name { get; set; }

        [XmlElement(IsNullable = true)]
        public string LastLogin { get; set; }

        [XmlElement(IsNullable = true)]
        public List<HashPasswordLogin> LoginNames { get; set; }
    }
}
