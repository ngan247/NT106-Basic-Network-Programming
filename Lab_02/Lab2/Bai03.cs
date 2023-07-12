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
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void Bai03_Load(object sender, EventArgs e)
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
            rtxt_tinh.Text = content.ToString();
            sr.Close();
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
            sw.Write(rtxt_kq.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                string s = rtxt_tinh.Text;
                s = s.Replace("\n", " "); // thay kí tự xuống dòng thành dấu cách
                string[] str = s.Split(' ');
                float t;
                for (int i = 1; i < str.Length - 1; i += 3)
                {
                    rtxt_kq.Text += str[i - 1].ToString() + str[i].ToString() + str[i + 1].ToString() + " = ";
                    if (str[i] == "+")
                    {
                        t = float.Parse(str[i - 1]) + float.Parse(str[i + 1]);
                        rtxt_kq.Text += t.ToString("#.#");
                    }
                    else if (str[i] == "-")
                    {
                        t = float.Parse(str[i - 1]) - float.Parse(str[i + 1]);
                        rtxt_kq.Text += t.ToString("#.#");
                    }
                    else if (str[i] == "*")
                    {
                        t = float.Parse(str[i - 1]) * float.Parse(str[i + 1]);
                        rtxt_kq.Text += t.ToString("#.#");
                    }
                    else
                    {
                        t = float.Parse(str[i - 1]) / float.Parse(str[i + 1]);
                        rtxt_kq.Text += t.ToString("#.#");
                    }
                    rtxt_kq.Text += "\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn file đúng định dạng: x # y");
                rtxt_kq.Text = String.Empty;
            }
        }
    }
}
