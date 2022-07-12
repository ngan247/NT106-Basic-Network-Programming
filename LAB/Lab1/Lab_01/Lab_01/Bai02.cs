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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            float max, min;
            try
            {
                num1 = float.Parse(txt_so1.Text);
                num2 = float.Parse(txt_so2.Text);
                num3 = float.Parse(txt_so3.Text);
                max = num1;
                min = num2;
                if ( max < min)
                {
                    max = num2;
                    min = num1;
                }
                if (max < num3) max = num3;
                if (min > num3) min = num3;
                txt_max.Text = max.ToString();
                txt_min.Text = min.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_so1.Text = string.Empty;
            txt_so2.Text = string.Empty;
            txt_so3.Text = string.Empty;
            txt_max.Text = string.Empty;
            txt_min.Text = string.Empty;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
