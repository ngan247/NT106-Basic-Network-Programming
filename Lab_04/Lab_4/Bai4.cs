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
using HtmlAgilityPack;

namespace Lab_4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            // fix lỗi script error
            web_browser.ScriptErrorsSuppressed = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            web_browser.Navigate(txt_url.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            web_browser.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            web_browser.GoForward();
        }

        private void web_browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txt_url.Text = web_browser.Url.ToString();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            web_browser.Navigate("https://www.google.com");
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            var web = new HtmlWeb();
            var doc = web.Load(web_browser.Url.ToString());
            //doc.Save(sw);

            /* mở hộp lưu file */
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "sourceBai4.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                /* ghi file */
                FileStream fs = new FileStream(sfd.FileName.ToString(), FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                doc.Save(sw);
                sw.Flush();
                sw.Close();
            }
        }


        private void btn_view_Click(object sender, EventArgs e)
        {
            Bai4_b Child = new Bai4_b(txt_url.Text);
            Child.Show();
        }
    }
}
