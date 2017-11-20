// ReSharper disable InconsistentNaming

using System;
using System.ComponentModel;
using System.Xml.Serialization;

// ReSharper disable UnusedMember.Global

namespace OctoClient
{
#pragma warning disable IDE1006 // Naming Styles
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class RDCMan
    {
        private RDCManFile fileField;

        private decimal programVersionField;

        private byte schemaVersionField;


        /// <remarks />
        public RDCManFile file

        {
            get => fileField;
            set => fileField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public decimal programVersion
        {
            get => programVersionField;
            set => programVersionField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public byte schemaVersion
        {
            get => schemaVersionField;
            set => schemaVersionField = value;
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
