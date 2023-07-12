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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Bai1_client form = new Bai1_client();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1_server form = new Bai1_server();
            form.Show();

        }
    }
}
