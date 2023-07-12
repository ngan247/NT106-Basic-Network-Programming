using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Server().Show();
            button1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            new Client().Show();
            btn2.Enabled = false;
        }
    }
}
