using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WiiTracker
{
    public partial class SiteEditForm : Form
    {
        protected Dictionary<string, string> values;

        public SiteEditForm(Dictionary<string,string> values)
        {
            this.values = values;
            InitializeComponent();
            if (this.values != null)
            {
                if (this.values["name"] != null)
                    this.tbName.Text = this.values["name"];
                if (this.values["url"] != null)
                    this.tbUrl.Text = this.values["url"];
                if (this.values["searchString"] != null)
                    this.tbSearchString.Text = this.values["searchString"];

                if (this.values["enabled"] != null)
                    this.cbEnabled.Checked = bool.Parse(this.values["enabled"]);
                if (this.values["invertLogic"] != null)
                    this.cbInvertLogic.Checked = bool.Parse(this.values["invertLogic"]);
            }
        }

        public Dictionary<string, string> Values
        {
            get
            {
                return this.values;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (values == null)
            {
                values = new Dictionary<string, string>();
            }
            this.values["name"] = tbName.Text;
            this.values["url"] = tbUrl.Text;
            this.values["searchString"] = tbSearchString.Text;
            this.values["enabled"] = this.cbEnabled.Checked.ToString().ToLower();
            this.values["invertLogic"] = this.cbInvertLogic.Checked.ToString().ToLower();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}