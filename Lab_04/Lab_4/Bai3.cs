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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            string fileurl = txt_path.Text;
            string url = txt_url.Text;
            try
            {
                // get html
                WebClient myClient = new WebClient();
                //Stream response = myClient.OpenRead(url);

                // dowload html file
                myClient.DownloadFile(url, fileurl);
                MessageBox.Show("Lưu file thành công");

                /* đọc file */
                FileStream fs = new FileStream(fileurl, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rtxt_box.Text = sr.ReadToEnd();
                fs.Close();
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
