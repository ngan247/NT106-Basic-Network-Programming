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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Bai4_server form = new Bai4_server();
            form.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            form.Show();
        }
    }
}
