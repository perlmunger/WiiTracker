using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WiiTracker.ConfigSections
{
    [XmlRoot("SMSConfig")]
    class SMSConfig
    {
        public SMSConfig()
        {
            this.urls = new SMSUrlCollection();
        }

        [XmlArray("smsurl")]
        [XmlArrayItem("attribute", typeof(SMSUrlAttribute))]
        public SMSUrlCollection urls;
    }
}
