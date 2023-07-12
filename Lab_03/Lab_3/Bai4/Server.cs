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
    public partial class Bai4_server : Form
    {
        public Bai4_server()
        {
            InitializeComponent();
        }

        IPEndPoint IPServer;

        Socket[] clientnumber = new Socket[99];
        string[] clientname = new string[99];
        int clientcount = 0;

        void Connect()
        {
            IPServer = new IPEndPoint(IPAddress.Any, 8080);
            TcpListener tcplistener = new TcpListener(IPServer);
            try
            {
                while (true)
                {
                    tcplistener.Start();
                    Socket client = tcplistener.AcceptSocket();
                    ++clientcount;
                    clientnumber[clientcount] = client;
                    clientname[clientcount] = Client.NameClient;
                    listView.Items.Add(new ListViewItem("New client connected, Name: " + clientname[clientcount]));

                    Thread rcvv = new Thread(Receive);
                    rcvv.IsBackground = true;
                    rcvv.Start(client);
                }
            }
            catch
            {
                tcplistener.Start();
            }

        }
        void Send(Socket client, string text)
        {
            //text = Name + ": " + text;
            text.Replace("\r\n", "");
            text.Replace("\n", "");
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            client.Send(data);
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            int number = 100;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 99];
                    client.Receive(data);
                    string text = Encoding.UTF8.GetString(data);
                    listView.Items.Add(new ListViewItem(Text = text));
                    for (number = 1; number < clientcount; number++)
                    {
                        if (client == clientnumber[number]) { break; }
                    }
                    for (int i = 1; i <= clientcount; i++)
                        if (i != number) Send(clientnumber[i], text);
                }
            }
            catch
            {
                client.Close();
            }
        }
        private void btn_listen_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Columns.Add("Running...", 512);

            btn_listen.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(Connect));
            thdUDPServer.Start();

        }

        private void Bai4_server_Load(object sender, EventArgs e)
        {

        }

    }
}
