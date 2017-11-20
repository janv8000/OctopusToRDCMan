using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OctoClient
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class RDCManFileProperties
    {
        private string nameField;

        /// <remarks />
        public string name
        {
            get => nameField;
            set => nameField = value;
        }
    }
}