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
using System.IO;

namespace Lab_4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            rtxt_box.Clear();
            listView.Clear();
            try
            {
                WebClient myClient = new WebClient();
                byte[] response = myClient.DownloadData(txt_url.Text);
                rtxt_box.Text = Encoding.UTF8.GetString(response);
                WebHeaderCollection whc = myClient.ResponseHeaders;

                // Tạo tên cột
                listView.View = View.Details;
                listView.Columns.Add("STT");
                listView.Columns.Add("Header");
                listView.Columns.Add("Value");

                string[] header = whc.AllKeys;
                int k = 1;
                foreach (string str in header)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = k.ToString();
                    k++;
                    item.SubItems.Add(str);
                    item.SubItems.Add(whc.Get(str));
                    listView.Items.Add(item);
                }
                // Autosize cho columns
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    listView.Columns[i].Width = -2;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Invalid url!");
            }
        }
    }
}
