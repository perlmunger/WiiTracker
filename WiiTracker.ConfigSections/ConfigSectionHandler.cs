using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.Xml;

namespace WiiTracker.ConfigSections
{
    class ConfigSectionHandler : IConfigurationSectionHandler
    {
        #region IConfigurationSectionHandler Members

        object IConfigurationSectionHandler.Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            XPathNavigator xNav = section.CreateNavigator();
            string typeOfObject = (string)xNav.Evaluate("string(@type)");
            Type t = Type.GetType(typeOfObject);
            XmlSerializer ser = new XmlSerializer(t);
            XmlNodeReader xNodeReader = new XmlNodeReader(section);
            return ser.Deserialize(xNodeReader);
        }

        #endregion
    }
}
