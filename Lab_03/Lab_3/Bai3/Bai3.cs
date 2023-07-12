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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            Bai3_server bai3_Server = new Bai3_server();
            bai3_Server.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Bai3_client client = new Bai3_client();
            client.Show();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
