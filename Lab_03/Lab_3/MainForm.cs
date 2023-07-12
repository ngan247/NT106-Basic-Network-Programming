using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Bai2().ShowDialog();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            new Bai1().ShowDialog();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            new Bai3().ShowDialog();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            new Bai4().ShowDialog();
        }
    }
}
