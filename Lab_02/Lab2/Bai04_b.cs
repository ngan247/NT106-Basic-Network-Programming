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
    public partial class Bai04_b : Form
    {
        public Bai04_b()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                float num1, num2;
                num1 = float.Parse(txt_toan.Text);
                num2 = float.Parse(txt_toan.Text);
                if (num1 > 10 || num1 < 0) throw new Exception();
                if (num2 > 10 || num2 < 0) throw new Exception();
                string str = "";
                str = txt_name.Text + ";" + txt_mssv.Text + ";" + txt_sdt.Text + ";"
                    + num1 + ";" + num2 + "\n";

                // lưu file 
                // ghi tiếp file với append
                StreamWriter sw = File.AppendText("E:/input.txt");
                sw.Write(str);
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại số!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_van.Text = String.Empty;
            txt_toan.Text = String.Empty;
            txt_mssv.Text = String.Empty;
            txt_name.Text = String.Empty;
            txt_sdt.Text = String.Empty;
        }
    }
}
