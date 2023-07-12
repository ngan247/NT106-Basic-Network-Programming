using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Lab_3
{
    public partial class Bai1_client : Form
    {
        public Bai1_client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bai1_client_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            UdpClient uclient = new UdpClient();
            uclient.Connect(txt_ip.Text, int.Parse(txt_port.Text));
            Byte[] message = Encoding.UTF8.GetBytes(rtxt_client.Text);
            uclient.Send(message, message.Length);
        }
    }
}
