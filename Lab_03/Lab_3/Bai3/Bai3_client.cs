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
    public partial class Bai3_client : Form
    {
        public Bai3_client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        NetworkStream ns;

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                // 4.gửi dữ liệu đến server bằng phương thức write
                Byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello server\n");
                ns.Write(data, 0, data.Length);
            }
            // bắt lỗi Send mà server đã đóng hoặc mở lại nhưng chưa connect
            catch (Exception)
            {
                btn_send.Enabled = false;
                btn_exit.Enabled = false;
                btn_connect.Enabled = true;
                MessageBox.Show("Need connected");
            }
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] dataa = System.Text.Encoding.UTF8.GetBytes("Quit\n");
                ns.Write(dataa, 0, dataa.Length);
                ns.Close();
                tcpClient.Close();
                btn_send.Enabled = false;
                btn_exit.Enabled = false;
                btn_connect.Enabled = true;
                MessageBox.Show("Client closed!");
            }
            // đóng client khi bên server đã đóng
            catch
            {
                btn_send.Enabled = false;
                btn_exit.Enabled = false;
                btn_connect.Enabled = true;
                MessageBox.Show("Client closed1");
            }
        }

        private void Bai3_client_Load(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.tạo tcp client
                tcpClient = new TcpClient();
                // 2.kết nối tới server với ip và port xác định
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ep = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ep);
                // 3.tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
                ns = tcpClient.GetStream();
                btn_send.Enabled = true;
                btn_exit.Enabled = true;
                btn_connect.Enabled = false;
            }
            //server chưa listen
            catch (Exception)
            {
                btn_send.Enabled = false;
                btn_exit.Enabled = false;
                btn_connect.Enabled = true;
                MessageBox.Show("Server is not ready!");
            }
        }
    }
}
