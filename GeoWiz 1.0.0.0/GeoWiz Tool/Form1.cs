using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace GeoWiz
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string GetIPAddress(string hostname)
        {
            IPHostEntry host = Dns.GetHostEntry(hostname);
            return host.AddressList[0].ToString();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                string target = comboBoxEdit1.SelectedIndex == 0 ? textEdit1.Text : GetIPAddress(textEdit1.Text);
                string url = $"http://ip-api.com/json/{target}";
                string result = "";

                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    dynamic location = JsonConvert.DeserializeObject(json);

                    result += "IP: " + location.query + Environment.NewLine;
                    result += "Country: " + location.country + Environment.NewLine;
                    result += "Region: " + location.regionName + Environment.NewLine;
                    result += "City: " + location.city + Environment.NewLine;
                    result += "Latitude: " + location.lat + Environment.NewLine;
                    result += "Longitude: " + location.lon + Environment.NewLine;
                    result += "Timezone: " + location.timezone + Environment.NewLine;
                    result += "ISP: " + location.isp + Environment.NewLine;
                    result += "Organization: " + location.org + Environment.NewLine;
                    result += "As: " + location.ast + Environment.NewLine;
                    result += "Status: " + location.status + Environment.NewLine;
                }

                MemoEdit memoEdit = new MemoEdit
                {
                    Dock = DockStyle.Fill,
                    Text = result,
                    ReadOnly = true
                };

                using (XtraForm dialog = new XtraForm())
                {
                    dialog.StartPosition = FormStartPosition.CenterParent;
                    dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                    dialog.MaximizeBox = false;
                    dialog.MinimizeBox = false;
                    dialog.Controls.Add(memoEdit);
                    dialog.ClientSize = new Size(500, 300);
                    dialog.ShowDialog(this);
                }
            }
            else if (comboBoxEdit1.SelectedIndex == 1)
            {
                string target = comboBoxEdit1.SelectedIndex == 1 ? textEdit1.Text : GetIPAddress(textEdit1.Text);
                string url = $"http://ip-api.com/json/{target}";
                string result = "";

                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    dynamic location = JsonConvert.DeserializeObject(json);

                    result += "IP: " + location.query + Environment.NewLine;
                    result += "Country: " + location.country + Environment.NewLine;
                    result += "Region: " + location.regionName + Environment.NewLine;
                    result += "City: " + location.city + Environment.NewLine;
                    result += "Latitude: " + location.lat + Environment.NewLine;
                    result += "Longitude: " + location.lon + Environment.NewLine;
                    result += "Timezone: " + location.timezone + Environment.NewLine;
                    result += "ISP: " + location.isp + Environment.NewLine;
                    result += "Organization: " + location.org + Environment.NewLine;
                    result += "As: " + location.ast + Environment.NewLine;
                    result += "Status: " + location.status + Environment.NewLine;
                }

                MemoEdit memoEdit = new MemoEdit
                {
                    Dock = DockStyle.Fill,
                    Text = result,
                    ReadOnly = true
                };

                using (XtraForm dialog = new XtraForm())
                {
                    dialog.StartPosition = FormStartPosition.CenterParent;
                    dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                    dialog.MaximizeBox = false;
                    dialog.MinimizeBox = false;
                    dialog.Controls.Add(memoEdit);
                    dialog.ClientSize = new Size(500, 300);
                    dialog.ShowDialog(this);
                }
            }
        }
    }
}
