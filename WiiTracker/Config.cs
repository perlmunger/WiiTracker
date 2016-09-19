using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace WiiTracker
{
    public sealed class SitesSection : ConfigurationSection
    {
        public SitesSection()
        {
        }
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public SitesCollection Sites
        {
            get
            {
                return (SitesCollection)base[""];
            }
        }
    }

    public sealed class SitesCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new SiteElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SiteElement)element).Name;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }
        protected override string ElementName
        {
            get
            {
                return "site";
            }
        }
    }

    public sealed class SiteGroup : ConfigurationSectionGroup
    {
        public SiteGroup()
        {

        }
    }

    public sealed class SiteElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)base["name"];
            }
            set
            {
                base["name"] = value;
            }
        }
        [ConfigurationProperty("url", IsRequired = true)]
        public string Url
        {
            get
            {
                return (string)base["url"];
            }
            set
            {
                base["url"] = value;
            }
        }
        [ConfigurationProperty("searchString", IsRequired = true)]
        public string SearchString
        {
            get
            {
                return (string)base["searchString"];
            }
            set
            {
                base["searchString"] = value;
            }
        }
        public override string ToString()
        {
            string output = "SiteElement :\n";
            output += string.Format("Name = {0}\n", Name);
            output += string.Format("Url = {0}\n", Url);
            output += string.Format("SearchString = {0}\n", SearchString);
            return output;
        }
    }
}
