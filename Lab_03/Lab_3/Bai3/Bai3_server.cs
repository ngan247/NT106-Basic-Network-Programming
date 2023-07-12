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
    public partial class Bai3_server : Form
    {
        public Bai3_server()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            rtxt_box.Clear();
            btn_listen.Enabled = false;
            // xử lí lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        Socket clientSocket;
        Socket listenerSocket;
        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            // tạo socket bên gửi
            // tạo socket bên nhận, với địa chỉ ip của máy và port 8080, TCP/IP socket
            // 3 tham số của hàm để thực hiện kết nối TCP
            listenerSocket = new Socket(
                // trả về họ địa chỉ của IP hiện hành
                AddressFamily.InterNetwork, // IPv4
                                            // kiểu kết nối socket: luồng stream nhận dữ liệu
                SocketType.Stream,
                // chọn giao thức tcp
                ProtocolType.Tcp);

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            // gán socket listen với ip và port
            listenerSocket.Bind(ipepServer);

            // bắt đầu lắng nghe socket.Listen(int backlog)
            // backlog: độ dài tối đa của hàng đợi các kết nối đang xử lí
            listenerSocket.Listen(-1);
            
            try
            {
                // đồng ý kết nối
                clientSocket = listenerSocket.Accept();
                btn_exit.Enabled = true;
                rtxt_box.Text += "New client connected\n";
                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += Encoding.UTF8.GetString(recv);
                    }
                    while (text[text.Length - 1] != '\n');
                    rtxt_box.Text += text;
                    
                }

            }
            catch (Exception)
            {
                clientSocket.Close();
                listenerSocket.Close();
                MessageBox.Show("Server closed!");
                btn_listen.Enabled = true;
                btn_exit.Enabled = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            rtxt_box.Clear();
            clientSocket.Close();
            listenerSocket.Close();
            btn_listen.Enabled = true;
            btn_exit.Enabled = false;
        }
    }
}
