using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Net.Mail;
using System.Collections;

namespace WiiTracker
{
    public partial class WiiTrackerForm : Form
    {

        protected List<Dictionary<string, string>> items = new List<Dictionary<string, string>>();
        protected DateTime firstNotify;
        protected bool notified = false;
        protected List<LogItem> logs = new List<LogItem>();

        delegate void UpdateLoggingListCallback();
        delegate void StopTrackerCallback();
        delegate void GetCarrierCallback();
        delegate void SetStatuCallback(string status);

        protected string selectedCarrier = "";

        protected Dictionary<string, string> carriers = new Dictionary<string, string>();

        public WiiTrackerForm()
        {
            InitializeComponent();
            LoadCarriers();
            tmrMain.Interval = (int)this.nudFrequency.Value;
        }

        private void LoadCarriers()
        {
            carriers["Alaska Communications Systems"] = "ACS";
            carriers["Alltel"] = "ALLTEL";
            carriers["AT&T (Now Cingular)"] = "ATT";
            carriers["CellularOne"] = "CELLULARONE";
            carriers["Cincinnati Bell"] = "CINCINNATI_BELL";
            carriers["Cingular"] = "CINGULAR";
            carriers["MetroPCS"] = "METROPCS";
            carriers["Midwest Wireless"] = "MIDWEST_WIRELESS";
            carriers["Nextel"] = "NEXTEL";
            carriers["Omnipoint"] = "OMNIPOINT";
            carriers["Qwest"] = "QWEST";
            carriers["Sprint"] = "SPRINT";
            carriers["SunCom Wireless"] = "SUNCOM";
            carriers["T-Mobile"] = "TMOBILE";
            carriers["US Cellular"] = "USCELLULAR";
            carriers["Verizon"] = "VERIZON";
            carriers["Virgin Mobile"] = "VIRGIN";
            carriers["Western Wireless"] = "WESTERN_WIRELESS";

            this.cmbCarriers.Items.Clear();

            foreach (string carrier in carriers.Keys)
            {
                cmbCarriers.Items.Add(carrier);
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(CheckSites));
            thread.Start();
        }

        private void CheckSites()
        {
            try
            {
                foreach (Dictionary<string, string> item in items)
                {
                    if ((item["enabled"] != null && item["enabled"] == "false") || item["enabled"] == null)
                        continue;

                    UpdateStatus("Status: Checking " + item["name"] + " at " + item["url"] + ".");
                    WebRequest request = WebRequest.Create(item["url"]);

                    WebResponse response = request.GetResponse();
                    
                    Stream ReceiveStream = response.GetResponseStream();

                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                    StreamReader readStream = new StreamReader(ReceiveStream, encode);

                    string strResponse = readStream.ReadToEnd();
                    if (strResponse == null || strResponse.Length <= 0)
                        continue;

                    string regex = item["searchString"];

                    Regex reg = new Regex(regex, RegexOptions.IgnoreCase);

                    bool invertLogic = false;

                    if (item["invertLogic"] != null)
                        invertLogic = bool.Parse(item["invertLogic"]);

                    bool isMatch = reg.IsMatch(strResponse);

                    if ((isMatch && !invertLogic) || (!isMatch && invertLogic))
                    {
                        UpdateStatus("Status: Not found at " + item["name"] + ".");
                    }
                    else if ((isMatch && invertLogic) || (!isMatch && !invertLogic))
                    {
                        if (!notified)
                        {
                            LogItem logItem = new LogItem("Wii Found at " + item["name"] + "!!", DateTime.Now, strResponse);
                            logs.Add(logItem);
                            UpdateStatus("Status: Item found at " + item["name"] + ".");
                            UpdateLogView();

                            notified = true;
                            Notify(item["name"], item["url"]);
                            niMain.BalloonTipText = "Wii is available! The Wii has been found at " + item["name"] + ".";
                            niMain.BalloonTipTitle = "Wii Avilable";
                            niMain.ShowBalloonTip(7000);
                            System.Diagnostics.Process.Start(item["url"]);
                            Stop();
                        }
                    }

                    readStream.Close();

                    response.Close();
                }
                UpdateStatus("Status: Idle");

            }
            catch (WebException ex)
            {
                /// There was a problem in the networking. Just ignore. We'll try again
                /// on the next go round.
                LogItem item = new LogItem(ex.Message, System.DateTime.Now, "");
                logs.Add(item);
                UpdateLogView();
            }
            catch (Exception ex)
            {
                LogItem item = new LogItem(ex.Message, System.DateTime.Now, "");
                logs.Add(item);
                UpdateLogView();
            }
        }

        private void UpdateStatus(string status)
        {
            if (lblStatus.InvokeRequired)
            {
                SetStatuCallback d = new SetStatuCallback(UpdateStatus);
                this.Invoke(d, status);
            }
            else
            {
                this.lblStatus.Text = status;
            }
        }

        private void UpdateLogView()
        {
            if (lvLogging.InvokeRequired)
            {
                UpdateLoggingListCallback d = new UpdateLoggingListCallback(UpdateLogView);
                this.Invoke(d);

            }
            else
            {
                this.lvLogging.Items.Clear();
                Array.Sort<LogItem>(logs.ToArray());
                Array.Reverse(logs.ToArray());
                foreach (LogItem item in logs)
                {
                    ListViewItem lvItem = new ListViewItem(new string[] { item.LogDate.ToString(), item.Message });
                    this.lvLogging.Items.Insert(0, lvItem);
                }
            }
        }

        private void Notify(string name, string url)
        {
            UpdateStatus("Status: Notifying...");
            if (tbEmail.Text.Length > 0 && tbSmtpServer.Text.Length > 0 &&
                tbSmtpUsername.Text.Length > 0 && tbSmtpPassword.Text.Length > 0)
            {
                /// Send an email
                /// 
                System.Net.Mail.MailMessage message = new MailMessage(tbEmail.Text, tbEmail.Text);
                message.Subject = "Wii found at " + name;
                string body = "A Wii has been found at " + name + ". Go to the following url to checkout: " + url;
                message.Body = body;

                System.Net.Mail.SmtpClient client = new SmtpClient(this.tbSmtpServer.Text);
                client.Port = int.Parse(tbPort.Text);
                client.Credentials = new System.Net.NetworkCredential(tbSmtpUsername.Text, tbSmtpPassword.Text);
                client.SendCompleted += new SendCompletedEventHandler(client_SendCompleted);
                client.SendAsync(message, (object)message);
            }

            if (tbNumberFrom.Text.Length > 0 && tbNumberToDial.Text.Length > 0 &&
                tbCallerIDName.Text.Length > 0)
            {
                /// Call web service to dial number
                /// 

                com.cdyne.ws.PhoneNotify notify = new WiiTracker.com.cdyne.ws.PhoneNotify();
                com.cdyne.ws.NotifyReturn ret = notify.NotifyPhoneBasic(tbNumberToDial.Text, name + " has a wii available.", tbNumberFrom.Text,
                    tbCallerIDName.Text, "0", "0");
                string resp = ret.ResponseText;
            }

            if (tbSmsPhone.Text.Length > 0)
            {
                WebRequest request = WebRequest.Create("http://www.google.com/sendtophone");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                string parameters = "";
                parameters += "g1=US&";
                parameters += "h1=en&";
                parameters += "client=navclient-ffsms&";
                //parameters += "text=&";
                parameters += "c=1&";
                //parameters += "ec=on&";
                parameters += "mobile_user_id=" + tbSmsPhone.Text + "&";
                GetCarrier();
                parameters += "carrier=" + selectedCarrier + "&";
                parameters += "subject=" + System.Web.HttpUtility.UrlEncode("Wii found at " + name + ".") + "&";
                parameters += "text=" + System.Web.HttpUtility.UrlEncode("A Wii was found at " + name + ".");

                byte[] bytes = Encoding.ASCII.GetBytes(parameters);

                Stream os = null;
                request.ContentLength = bytes.Length;   //Count bytes to send
                os = request.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);         //Send it

                WebResponse response = request.GetResponse();
                if (response == null)
                {
                    os.Close();
                    return;
                }
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string resp = sr.ReadToEnd().Trim();
                os.Close();
            }
            UpdateStatus("Status: Finished");

        }

        private void GetCarrier()
        {
            if (cmbCarriers.InvokeRequired)
            {
                GetCarrierCallback d = new GetCarrierCallback(GetCarrier);
                this.Invoke(d);
            }
            else
            {
                selectedCarrier = carriers[(string)cmbCarriers.SelectedItem];
            }
        }

        void client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (endSessionPending)
            {
                // The session is ending.
                e.Cancel = false;
            }
            else
            {
                // The window must only be minimized in tray
                e.Cancel = true;
                MinimizeInTray();
            }


            base.OnClosing(e);
        }

        private void MinimizeInTray()
        {
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ShowFromTray()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private const int WM_QUERYENDSESSION = 0x11;
        private bool endSessionPending;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_QUERYENDSESSION)
                endSessionPending = true;
            base.WndProc(ref m);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowFromTray();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            ShowFromTray();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            tmrMain.Start();
            notified = false;
            SetControlsEnabled(false);

            LogItem item = new LogItem("Tracker Started.", System.DateTime.Now, "");
            logs.Add(item);
            UpdateLogView();
            this.btnStop.Enabled = true;
            this.btnStart.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            if (nudFrequency.InvokeRequired)
            {
                StopTrackerCallback d = new StopTrackerCallback(Stop);
                this.Invoke(d);
            }
            else
            {
                tmrMain.Stop();
                SetControlsEnabled(true);

                LogItem item = new LogItem("Tracker Stopped.", System.DateTime.Now, "");
                logs.Add(item);
                UpdateLogView();
            }
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;
        }

        private void SetControlsEnabled(bool enable)
        {
            this.nudFrequency.Enabled = enable;
            this.tbCallerIDName.Enabled = enable;
            this.tbEmail.Enabled = enable;
            this.tbNumberFrom.Enabled = enable;
            this.tbNumberToDial.Enabled = enable;
            this.tbPort.Enabled = enable;
            this.tbSmsPhone.Enabled = enable;
            this.tbSmtpPassword.Enabled = enable;
            this.tbSmtpServer.Enabled = enable;
            this.tbSmtpUsername.Enabled = enable;
            this.btnClearLog.Enabled = enable;
            this.cmbCarriers.Enabled = enable;
        }

        private void niMain_BalloonTipClicked(object sender, EventArgs e)
        {
        }

        private void WiiTrackerForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProperties();
                LoadSites();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void LoadProperties()
        {
            this.tbSmtpServer.Text = ConfigurationManager.AppSettings["smtpServer"];
            this.tbPort.Text = ConfigurationManager.AppSettings["smtpPort"];
            this.tbSmtpUsername.Text = ConfigurationManager.AppSettings["smtpUsername"];
            this.tbSmtpPassword.Text = ConfigurationManager.AppSettings["smtpPassword"];
            this.tbEmail.Text = ConfigurationManager.AppSettings["email"];
            this.tbNumberToDial.Text = ConfigurationManager.AppSettings["numberToDial"];
            this.tbNumberFrom.Text = ConfigurationManager.AppSettings["numberFrom"];
            this.tbCallerIDName.Text = ConfigurationManager.AppSettings["callerIdName"];
            this.tbSmsPhone.Text = ConfigurationManager.AppSettings["smsPhoneNumber"];
            this.cmbCarriers.SelectedItem = ConfigurationManager.AppSettings["smsCarrier"];
            this.nudFrequency.Value = decimal.Parse(ConfigurationManager.AppSettings["checkFrequency"]);

        }

        private void LoadSites()
        {
            //Stream s =
            //Assembly.GetExecutingAssembly().GetManifestResourceStream("WiiTracker.Sites.xml");

            XmlDocument doc = new XmlDocument();

            //StreamReader reader = new StreamReader(s);

            doc.Load("Sites.xml");

            //reader.Close();

            XmlNodeList elements = doc.DocumentElement.GetElementsByTagName("sites");

            items.Clear();
            this.lvMain.Items.Clear();

            foreach (XmlNode node in elements)
            {
                if (node.HasChildNodes)
                {
                    foreach (XmlNode siteNode in node.ChildNodes)
                    {
                        if (siteNode.HasChildNodes)
                        {
                            Dictionary<string, string> record = new Dictionary<string, string>();
                            foreach (XmlNode chNode in siteNode.ChildNodes)
                            {
                                if (chNode.Name.Equals("url"))
                                    record["url"] = chNode.InnerText;
                                if (chNode.Name.Equals("searchString"))
                                    record["searchString"] = chNode.InnerText;
                            }
                            if (siteNode.Attributes["name"] != null)
                                record["name"] = siteNode.Attributes["name"].Value;
                            if (siteNode.Attributes["enabled"] != null)
                                record["enabled"] = siteNode.Attributes["enabled"].Value;
                            if (siteNode.Attributes["invertLogic"] != null)
                                record["invertLogic"] = siteNode.Attributes["invertLogic"].Value;

                            items.Add(record);
                            ListViewItem item = new ListViewItem(new string[] { record["name"], record["url"], record["searchString"], record["invertLogic"] });
                            if( record["enabled"] == "false" )
                                item.ForeColor = Color.LightGray;
                            this.lvMain.Items.Add(item);
                        }
                    }
                }

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvLogging_DoubleClick(object sender, EventArgs e)
        {
            int index = lvLogging.SelectedIndices[0];
            if (index > -1 && index < logs.Count )
            {
                LogItem item = logs[index];
                PageViewer vwr = new PageViewer(item.Page, "WIITRACKER_" + System.DateTime.Now.Ticks.ToString());
                vwr.Show(this);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.logs.Clear();
            this.UpdateLogView();
        }

        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvMain.SelectedIndices != null && this.lvMain.SelectedIndices.Count > 0)
            {
                int index = this.lvMain.SelectedIndices[0];

                SiteEditForm sef = new SiteEditForm(items[index]);
                if (sef.ShowDialog() == DialogResult.OK)
                {
                    UpdateItems();
                    LoadSites();
                }
            }
        }

        private void UpdateItems()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Sites.xml");

            XmlNodeList siteNode = doc.DocumentElement.GetElementsByTagName("sites");
            if (siteNode != null)
            {
                XmlNode site = siteNode[0];

                site.RemoveAll();
                foreach (Dictionary<string, string> item in items)
                {
                    XmlElement siteElem = doc.CreateElement("site");

                    XmlAttribute name = doc.CreateAttribute("name");
                    name.Value = item["name"];

                    XmlAttribute enabled = doc.CreateAttribute("enabled");
                    enabled.Value = item["enabled"];

                    XmlAttribute invertLogic = doc.CreateAttribute("invertLogic");
                    invertLogic.Value = item["invertLogic"];

                    siteElem.Attributes.Append(name);
                    siteElem.Attributes.Append(enabled);
                    siteElem.Attributes.Append(invertLogic);

                    XmlElement urlElem = doc.CreateElement("url");
                    XmlCDataSection section = doc.CreateCDataSection(item["url"]);
                    urlElem.InnerXml = section.OuterXml;

                    XmlElement searchStringElem = doc.CreateElement("searchString");
                    XmlCDataSection ssSection = doc.CreateCDataSection(item["searchString"]);
                    searchStringElem.InnerXml = ssSection.OuterXml;

                    siteElem.AppendChild(urlElem);
                    siteElem.AppendChild(searchStringElem);

                    site.AppendChild(siteElem);
                }
                doc.Save(@"Sites.xml");
            }


        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiteEditForm sef = new SiteEditForm(null);
            if (sef.ShowDialog() == DialogResult.OK)
            {
                this.items.Add(sef.Values);
                UpdateItems();
                LoadSites();
            }

        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiteEditForm sef = new SiteEditForm(null);
            if (sef.ShowDialog() == DialogResult.OK)
            {
                this.items.Add(sef.Values);
                UpdateItems();
                LoadSites();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvMain.SelectedIndices != null && this.lvMain.SelectedIndices.Count > 0)
            {
                int index = this.lvMain.SelectedIndices[0];

                SiteEditForm sef = new SiteEditForm(items[index]);
                if (sef.ShowDialog() == DialogResult.OK)
                {
                    UpdateItems();
                    LoadSites();
                }
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvMain.SelectedIndices != null && this.lvMain.SelectedIndices.Count > 0)
            {
                int index = this.lvMain.SelectedIndices[0];

                Dictionary<string, string> item = items[index];
                items.Remove(item);
                UpdateItems();
                LoadSites();
            }
        }

        private void cmSitesList_Opening(object sender, CancelEventArgs e)
        {
            if (this.lvMain.SelectedIndices != null && this.lvMain.SelectedIndices.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void tsmiSaveConfig_Click(object sender, EventArgs e)
        {
            ReplaceConfigSettings("smtpServer", this.tbSmtpServer.Text );
            ReplaceConfigSettings("smtpPort", this.tbPort.Text );
            ReplaceConfigSettings("smtpUsername", this.tbSmtpUsername.Text );
            ReplaceConfigSettings("smtpPassword", this.tbSmtpPassword.Text );
            ReplaceConfigSettings("email", this.tbEmail.Text );
            ReplaceConfigSettings("numberToDial", this.tbNumberToDial.Text );
            ReplaceConfigSettings("numberFrom", this.tbNumberFrom.Text );
            ReplaceConfigSettings("callerIdName", this.tbCallerIDName.Text );
            ReplaceConfigSettings("smsPhoneNumber", this.tbSmsPhone.Text );
            ReplaceConfigSettings("smsCarrier", this.cmbCarriers.SelectedItem.ToString() );
            ReplaceConfigSettings("checkFrequency", this.nudFrequency.Value.ToString() );
        }

        private void ReplaceConfigSettings(string key, string val)
        {
            XmlDocument xDoc = new XmlDocument();
            try
            {
                // load the configuration file
                xDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                // find the node of interest containing the key using XPATH
                XmlNode theNode = xDoc.SelectSingleNode(@"/configuration/appSettings/add[@key = '" + key + "\']");
                // Set the new value for the node
                if (theNode != null)
                    theNode.Attributes["value"].Value = val;
                // save the new configuration settings
                xDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\App.config");
                xDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile); 
//                xDoc.Save(sFileName);
                xDoc = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("replaceConfigSettings()" + ex.Message);
                xDoc = null;
            }
        }
    }

    public class LogItem : IComparable
    {
        public LogItem() { }

        public LogItem(string message, DateTime date, string page)
        {
            this.message = message;
            this.logDate = date;
            this.page = page;
        }

        private DateTime logDate;

        public DateTime LogDate
        {
            get { return logDate; }
            set { logDate = value; }
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private string page;

        public string Page
        {
            get { return page; }
            set { page = value; }
        }


        #region IComparable Members

        public int CompareTo(object obj)
        {
            LogItem input = (LogItem)obj;
            return input.LogDate.CompareTo(this.LogDate);
        }

        #endregion
    }
}