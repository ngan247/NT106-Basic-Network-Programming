using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            /* mở hộp chọn file */
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files|*.txt"; // chỉ mở file .txt
            ofd.InitialDirectory = @"E:\"; // chọn đường dẫn ban đầu
            ofd.ShowDialog();

            /* đọc file */
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtxt_box.Text = content.ToString();
            sr.Close();

            // tên file 
            txt_name.Text = ofd.SafeFileName.ToString();

            // tên url
            txt_url.Text = fs.Name.ToString();

            // đếm số dòng
            content = content.Replace("\r\n", "\r");
            txt_dong.Text = rtxt_box.Lines.Count().ToString();
            content = content.Replace('\r', ' ');

            // đếm số từ
            string[] source = content.Split
                (
                new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                StringSplitOptions.RemoveEmptyEntries
                );
            txt_tu.Text = source.Count().ToString();
            // đếm ký tự
            txt_kytu.Text = content.Length.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
