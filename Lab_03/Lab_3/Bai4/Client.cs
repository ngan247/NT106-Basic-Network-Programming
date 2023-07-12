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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public static string NameClient = "";
        private void txt_name_TextChanged(object sender, EventArgs e)
        {
        }
        IPEndPoint IPServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        NetworkStream ns;
        void Connect()
        {
            TcpClient tcpclient = new TcpClient();
            IPAddress ipaddress = IPAddress.Parse("127.0.0.1");

            try
            {
                tcpclient.Connect(IPServer);
                ns = tcpclient.GetStream();

                Thread rcvv = new Thread(Receive);
                rcvv.IsBackground = true;
                rcvv.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error\n" + error.Message);
            }
        }
        void Send()
        {
            if (txt_mess.Text != "")
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(txt_name.Text + ": " + txt_mess.Text);
                ns.Write(data, 0, data.Length);
                listview.Items.Add(new ListViewItem(Text = txt_name.Text + ": " + txt_mess.Text));
            }
        }
        void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 99];
                    ns.Read(data, 0, data.Length);
                    string text = Encoding.UTF8.GetString(data);
                    text.Replace("\r\n", "");
                    text.Replace("\n", "");
                    listview.Items.Add(new ListViewItem(Text = text));
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Send();
        }
         
        private void Bai4_client_Load(object sender, EventArgs e)
        {
            listview.View = View.Details;
            listview.FullRowSelect = true;
            listview.Columns.Add("Welcome to chatroom", 512);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Nhập your name! ");
            }
            else
            {
                NameClient = "";
                NameClient = txt_name.Text;
                btn_login.Enabled = false;
                btn_send.Enabled = true;
                txt_name.ReadOnly = true;
                Connect();
            }
        }
    }
}
