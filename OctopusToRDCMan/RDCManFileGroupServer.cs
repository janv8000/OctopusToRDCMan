using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OctoClient
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class RDCManFileGroupServer
    {
        private RDCManFileGroupServerProperties propertiesField;

        /// <remarks />
        public RDCManFileGroupServerProperties properties
        {
            get => propertiesField;
            set => propertiesField = value;
        }
    }
}