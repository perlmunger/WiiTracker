using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WiiTracker.ConfigSections
{
    [XmlRoot("attribute")]
    class SMSUrlAttribute
    {
        public SMSUrlAttribute() { }

        private string key;

        [XmlAttribute("key")]
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string value;

        [XmlAttribute("value")]
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

    }
}
