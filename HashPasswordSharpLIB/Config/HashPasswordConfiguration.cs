using System.Collections.Generic;
using System.Xml.Serialization;

namespace de.janbusch.HashPasswordSharp.lib.Config
{
    [XmlRoot(ElementName = "HashPassword")]
    public class HashPasswordConfiguration
    {
        [XmlIgnore]
        public string Filepath { get; set; }

        [XmlElement(IsNullable = false)]
        public HashPasswordHosts Hosts { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        public string DefaultHashType { get; set; }

        [XmlAttribute]
        public string DefaultCharset { get; set; }

        [XmlAttribute]
        public string DefaultPasswordLength { get; set; }

        [XmlAttribute]
        public string LastHost { get; set; }

        [XmlAttribute]
        public string Timeout { get; set; }

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
                result.Filepath = path;

                return result;
            }
        }
    }

    public class HashPasswordHosts
    {
        [XmlElement(ElementName = "Host", IsNullable = false)]
        public List<HashPasswordHost> Host { get; set; }

        [XmlAttribute]
        public string Count
        {
            get { return Host.Count.ToString(); }
        }
    }
}
