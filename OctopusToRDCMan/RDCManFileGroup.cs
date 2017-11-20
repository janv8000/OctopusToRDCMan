#pragma warning disable IDE1006 // Naming Styles
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OctoClient
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class RDCManFileGroup
    {
        private RDCManFileGroupProperties propertiesField;

        private RDCManFileGroupServer[] serverField;

        /// <remarks />
        public RDCManFileGroupProperties properties
        {
            get => propertiesField;
            set => propertiesField = value;
        }

        /// <remarks />
        [XmlElement("server")]
        public RDCManFileGroupServer[] server
        {
            get => serverField;
            set => serverField = value;
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
