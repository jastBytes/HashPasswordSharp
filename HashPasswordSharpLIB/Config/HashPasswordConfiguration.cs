using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JaSt.HashPasswordSharp.Library.Config
{
    [XmlRoot(ElementName = "HashPassword")]
    public class HashPasswordConfiguration
    {
        public delegate void ConfigChangedHandler(object sender, EventArgs e);
        public event ConfigChangedHandler ConfigChanged;

        [XmlIgnore]
        public string Filepath { get; set; }

        [XmlIgnore]
        public bool HasChanged { get; set; }

        [XmlElement(IsNullable = false)]
        public HashPasswordHosts Hosts
        {
            get { return _hosts; }
            set
            {
                var oldVal = value;
                _hosts = value;
                if (oldVal.Equals(_hosts)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private HashPasswordHosts _hosts;

        [XmlAttribute]
        public string Version
        {
            get { return _version; }
            set
            {
                var oldVal = value;
                _version = value;
                if (oldVal.Equals(_version)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _version;

        [XmlAttribute]
        public string DefaultHashType
        {
            get { return _defaultHashType; }
            set
            {
                var oldVal = value;
                _defaultHashType = value;
                if (oldVal.Equals(_defaultHashType)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _defaultHashType;

        [XmlAttribute]
        public string DefaultCharset
        {
            get { return _defaultCharset; }
            set
            {
                var oldVal = value;
                _defaultCharset = value;
                if (oldVal.Equals(_defaultCharset)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _defaultCharset;

        [XmlAttribute]
        public string DefaultPasswordLength
        {
            get { return _defaultPasswordLength; }
            set
            {
                var oldVal = value;
                _defaultPasswordLength = value;
                if (oldVal.Equals(_defaultPasswordLength)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _defaultPasswordLength;

        [XmlAttribute]
        public string LastHost
        {
            get { return _lastHost; }
            set
            {
                var oldVal = value;
                _lastHost = value;
                if (oldVal.Equals(_lastHost)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _lastHost;

        [XmlAttribute]
        public string Timeout
        {
            get { return _timeout; }
            set
            {
                var oldVal = value;
                _timeout = value;
                if (oldVal.Equals(_timeout)) return;
                ConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _timeout;

        public void SaveToXml(string path = null)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = Filepath;
            }

            var writer = new XmlSerializer(typeof(HashPasswordConfiguration));
            using (var file = new System.IO.StreamWriter(path))
            {
                writer.Serialize(file, this);
            }
            Filepath = path;
        }

        public static HashPasswordConfiguration LoadFromXml(string path)
        {
            var reader = new XmlSerializer(typeof(HashPasswordConfiguration));
            using (var file = new System.IO.StreamReader(path))
            {
                var result = (HashPasswordConfiguration)reader.Deserialize(file);
                result.Filepath = path;
                result.ConfigChanged += Result_ConfigChanged;
                result.HasChanged = false;
                return result;
            }
        }

        private static void Result_ConfigChanged(object sender, EventArgs e)
        {
            var hashPasswordConfiguration = sender as HashPasswordConfiguration;
            if (hashPasswordConfiguration != null) hashPasswordConfiguration.HasChanged = true;
        }
    }

    public class HashPasswordHosts
    {
        [XmlElement(ElementName = "Host", IsNullable = false)]
        public List<HashPasswordHost> Host { get; set; }

        [XmlAttribute]
        public string Count => Host.Count.ToString();
    }
}
