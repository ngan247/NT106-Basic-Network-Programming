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

namespace Lab_6
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        string Encrypt(string plaintext, int key)
        {
            string cipher = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                if (plaintext[i].ToString() == "\n" || plaintext[i].ToString() == " ")
                    cipher += plaintext[i].ToString();
                else if (char.IsUpper(plaintext[i]))
                {
                    char ch = (char)(((int)plaintext[i] + key - 65) % 26 + 65);
                    cipher += ch;
                }
                else
                {
                    char ch = (char)(((int)plaintext[i] + key - 97) % 26 + 97);
                    cipher += ch;
                }
            }
            return cipher;
        }


        TcpClient tcpClient;
        NetworkStream ns;
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

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                // 4.gửi dữ liệu đến server bằng phương thức write
                string message = "Hello Server\n";
                message = Encrypt(message, 7);
                Byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
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
                string message = "Good bye Server\n";
                message = Encrypt(message, 7);
                Byte[] dataa = System.Text.Encoding.UTF8.GetBytes(message);
                ns.Write(dataa, 0, dataa.Length);
                ns.Close();
                tcpClient.Close();
                btn_send.Enabled = false;
                btn_exit.Enabled = false;
                btn_connect.Enabled = true;
            }
            // đóng client khi bên server đã đóng
            catch
            {
                btn_send.Enabled = false;
                btn_exit.Enabled = false;
                btn_connect.Enabled = true;
                MessageBox.Show("Client closed!");
            }
        }
    }
}
