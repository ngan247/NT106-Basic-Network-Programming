using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_so.Text = string.Empty;
            txt_doc.Text = string.Empty;
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = Int32.Parse(txt_so.Text);
                if (n < 0 || n > 9) throw new Exception();
                switch (n)
                {
                    case 0:
                        txt_doc.Text = "Không";
                        break;
                    case 1:
                        txt_doc.Text = "Một";
                        break;
                    case 2:
                        txt_doc.Text = "Hai";
                        break;
                    case 3:
                        txt_doc.Text = "Ba";
                        break;
                    case 4:
                        txt_doc.Text = "Bốn";
                        break;
                    case 5:
                        txt_doc.Text = "Năm";
                        break;
                    case 6:
                        txt_doc.Text = "Sáu";
                        break;
                    case 7:
                        txt_doc.Text = "Bảy";
                        break;
                    case 8:
                        txt_doc.Text = "Tám";
                        break;
                    case 9:
                        txt_doc.Text = "Chín";
                        break;
                }    
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại số theo yêu cầu");
            }
        }
    }
}
