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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string[] str = txt_diem.Text.Split(' ');
            try
            {
                float[] arr = new float[str.Length];
                for(int i = 0; i < str.Length; i++)
                {
                    arr[i] = float.Parse(str[i]);
                    if (arr[i] < 0 || arr[i] > 10)
                        throw new Exception();
                }
                txt_dtb.Text = String.Format("{0:0.##}", Queryable.Average(arr.AsQueryable()));
                txt_max.Text = arr.Max().ToString();
                txt_min.Text = arr.Min().ToString();
                int num_dau = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 5) num_dau++;
                }   
                txt_dau.Text = num_dau.ToString();
                txt_kdau.Text = (arr.Length - num_dau).ToString();

                //xếp loại
                float num_dtb = float.Parse(txt_dtb.Text);
                float num_diemmin = float.Parse(txt_min.Text);
                if (num_dtb >= 8 && num_diemmin >= 6.5)
                    txt_xeploai.Text = "Giỏi";
                else if (num_dtb >= 6.5 && num_diemmin >= 5)
                    txt_xeploai.Text = "Khá";
                else if (num_dtb >= 5 && num_diemmin >= 3.5)
                    txt_xeploai.Text = "TB";
                else if (num_dtb >= 3.5 && num_diemmin >= 2)
                    txt_xeploai.Text = "Yếu";
                else
                    txt_xeploai.Text = "Kém";

                //xuất ds môn và điểm
                
                for(int i = 0; i < arr.Length && i < 6; i++)
                {
                    int k = i + 1;
                    txt_mon1.Text += "Môn " + k + ": " + arr[i] + Environment.NewLine;
                }
                for (int i = 6; i < arr.Length && i < 12; i++)
                {
                    int k = i + 1;
                    txt_mon2.Text += "Môn " + k + ": " + arr[i] + Environment.NewLine;
                }
                for (int i = 12; i < arr.Length && i < 18; i++)
                {
                    int k = i + 1;
                    txt_mon3.Text += "Môn " + k + ": " + arr[i] + Environment.NewLine;
                }
                for (int i = 18; i < arr.Length; i++)
                {
                    int k = i + 1;
                    txt_mon4.Text += "Môn " + k + ": " + arr[i] + Environment.NewLine;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập lại số");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diem1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
