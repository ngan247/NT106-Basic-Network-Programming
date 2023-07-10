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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            try
            {
                num1 = Int32.Parse(txt_so1.Text);
                num2 = Int32.Parse(txt_so2.Text);
                sum = (long)num1 + (long)num2;
                txt_sum.Text = sum.ToString(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_so1.Text = String.Empty;
            txt_so2.Text = String.Empty;
            txt_sum.Text = String.Empty;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
