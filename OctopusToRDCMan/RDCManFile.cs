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
    public class RDCManFile
    {
        private RDCManFileGroup[] groupField;

        private RDCManFileProperties propertiesField;


        /// <remarks />
        public RDCManFileProperties properties

        {
            get => propertiesField;
            set => propertiesField = value;
        }

        /// <remarks />
        [XmlElement("group")]
        public RDCManFileGroup[] group
        {
            get => groupField;
            set => groupField = value;
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
