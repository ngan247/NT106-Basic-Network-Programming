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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
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
            txt_box.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            /* mở hộp lưu file */
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "output.txt";
            sfd.ShowDialog();

            /* ghi file */
            FileStream fs = new FileStream(sfd.FileName.ToString(), FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(txt_box.Text.ToUpper());
            sw.Flush();
            sw.Close();
        }
    }
}
