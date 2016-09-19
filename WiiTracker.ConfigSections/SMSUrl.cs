using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WiiTracker.ConfigSections
{
    [XmlRoot("smsurl")]
    class SMSUrl
    {
        public SMSUrl() { }

        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

    }
}
