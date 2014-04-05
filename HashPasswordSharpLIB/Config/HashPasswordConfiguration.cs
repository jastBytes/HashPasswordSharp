using System.Collections.Generic;
using System.Xml.Serialization;

namespace de.janbusch.HashPasswordSharp.lib.Config
{
    [XmlRoot(ElementName = "HashPassword")]
    public class HashPasswordConfiguration
    {
        [XmlElement(IsNullable = false)]
        private List<HashPasswordHost> Hosts { get; set; }

        [XmlElement(IsNullable = true)]
        private int Version { get; set; }

        [XmlElement(IsNullable = true)]
        private string DefaultHashType { get; set; }

        [XmlElement(IsNullable = true)]
        private string DefaultCharset { get; set; }

        [XmlElement(IsNullable = true)]
        private string DefaultPasswordLength { get; set; }

        [XmlElement(IsNullable = true)]
        private string LastHost { get; set; }

        [XmlElement(IsNullable = true)]
        private int Timeout { get; set; }

        public void SaveToXml(string path)
        {
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(HashPasswordConfiguration));
            using (var file = new System.IO.StreamWriter(path))
            {
                writer.Serialize(file, this);
            }
        }

        public static HashPasswordConfiguration LoadFromXml(string path)
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(HashPasswordConfiguration));
            using (var file = new System.IO.StreamReader(path))
            {
                var result = (HashPasswordConfiguration)reader.Deserialize(file);
                return result;
            }
        }
    }
}
