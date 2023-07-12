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
    public partial class Bai1_server : Form
    {
        public Bai1_server()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            try
            {
                UdpClient uclient = new UdpClient(int.Parse(txt_port.Text));
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] message = uclient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.UTF8.GetString(message);
                    string mess = RemoteIpEndPoint.Address.ToString() + ": " +
                        returnData.ToString();
                    rtxt_server.Text += mess + "\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter port");
            }
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            btn_listen.Enabled = false;
            // xử lí lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
    }
}
