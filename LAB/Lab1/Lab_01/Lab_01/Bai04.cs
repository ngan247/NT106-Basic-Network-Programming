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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_so.Text = String.Empty;
            txt_ketqua.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                if (cbb_tu.Text == "Decimal")
                {
                    num = Int32.Parse(txt_so.Text);
                    if (cbb_sang.Text == "Binary")
                        txt_ketqua.Text = Convert.ToString(num, 2);
                    else if (cbb_sang.Text == "Hexadecimal")
                        txt_ketqua.Text = Convert.ToString(num, 16);
                    else if (cbb_sang.Text == "Decimal")
                        txt_ketqua.Text = txt_so.Text;
                    else MessageBox.Show("Vui lòng chọn cơ số");
                }
                else if (cbb_tu.Text == "Binary")
                {
                    if (cbb_sang.Text == "Decimal")
                        txt_ketqua.Text = Convert.ToInt32(txt_so.Text, 2).ToString();
                    else if (cbb_sang.Text == "Hexadecimal")
                        txt_ketqua.Text = Convert.ToInt32(txt_so.Text, 2).ToString("X");
                    else if (cbb_sang.Text == "Binary")
                    {
                        foreach (var c in txt_so.Text)
                            if (c != '0' && c != '1') MessageBox.Show("Vui lòng nhập đúng định dạng");
                            else
                                txt_ketqua.Text = txt_so.Text;
                    }
                    else MessageBox.Show("Vui lòng chọn cơ số");
                }    
                else if (cbb_tu.Text == "Hexadecimal")
                {
                    num = Int32.Parse(txt_so.Text, System.Globalization.NumberStyles.HexNumber);
                    if (cbb_sang.Text == "Binary")
                        txt_ketqua.Text = Convert.ToString(Convert.ToInt32(txt_so.Text, 16), 2);
                    else if (cbb_sang.Text == "Decimal")
                        txt_ketqua.Text = Convert.ToString(num, 10);
                    else if (cbb_sang.Text == "Hexadecimal")
                        txt_ketqua.Text = txt_so.Text;
                    else MessageBox.Show("Vui lòng chọn cơ số");
                }
                else MessageBox.Show("Vui lòng chọn cơ số");

            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }
    }
}
