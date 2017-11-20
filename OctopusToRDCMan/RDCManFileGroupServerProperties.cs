using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OctoClient
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class RDCManFileGroupServerProperties
    {
        private string commentField;

        private string displayNameField;

        private string nameField;

        /// <remarks />
        public string displayName
        {
            get => displayNameField;
            set => displayNameField = value;
        }

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        public string comment
        {
            get => commentField;
            set => commentField = value;
        }
    }
}