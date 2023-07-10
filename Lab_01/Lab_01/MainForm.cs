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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            new Bai01().ShowDialog();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            new Bai02().ShowDialog();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            new Bai03().ShowDialog();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            new Bai04().ShowDialog();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            new Bai05().ShowDialog();
        }
    }
}
