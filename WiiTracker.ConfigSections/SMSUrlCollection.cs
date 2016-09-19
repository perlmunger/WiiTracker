using System;
using System.Collections.Generic;
using System.Text;

namespace WiiTracker.ConfigSections
{
    class SMSUrlCollection : ICollection<SMSUrlAttribute>
    {
        private List<SMSUrlAttribute> urls;

        public SMSUrlCollection()
        {
            urls = new List<SMSUrlAttribute>();
        }

        #region ICollection<SMSUrlAttribute> Members

        void ICollection<SMSUrlAttribute>.Add(SMSUrlAttribute item)
        {
            urls.Add(item);
        }

        void ICollection<SMSUrlAttribute>.Clear()
        {
            urls.Clear();
        }

        bool ICollection<SMSUrlAttribute>.Contains(SMSUrlAttribute item)
        {
            return urls.Contains(item);
        }

        void ICollection<SMSUrlAttribute>.CopyTo(SMSUrlAttribute[] array, int arrayIndex)
        {
            urls.CopyTo(array, arrayIndex);
        }

        int ICollection<SMSUrlAttribute>.Count
        {
            get { return urls.Count; }
        }

        bool ICollection<SMSUrlAttribute>.IsReadOnly
        {
            get { return false; }
        }

        bool ICollection<SMSUrlAttribute>.Remove(SMSUrlAttribute item)
        {
            return urls.Remove(item);
        }

        #endregion

        #region IEnumerable<SMSUrlAttribute> Members

        IEnumerator<SMSUrlAttribute> IEnumerable<SMSUrlAttribute>.GetEnumerator()
        {
            return urls.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return urls.GetEnumerator();
        }

        #endregion
    }
}
