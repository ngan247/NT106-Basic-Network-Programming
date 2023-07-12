using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace Lab_4
{
    public partial class Bai4_b : Form
    {
        public Bai4_b()
        {
            InitializeComponent();
        }
        string rcvUrl;
        public Bai4_b(string url) : this()
        {
            rcvUrl = url;
            txt_url.Text = rcvUrl;
            WebClient myClient = new WebClient();
            byte[] response = myClient.DownloadData(txt_url.Text);
            rtxt_box.Text = Encoding.UTF8.GetString(response);
        }
    }
}
