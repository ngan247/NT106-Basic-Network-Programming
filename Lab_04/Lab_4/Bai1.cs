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
using System.IO;

namespace Lab_4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            rtxt_box.Clear();
            try
            {
                string url = txt_box.Text;
                // Create a request for the URL. 
                WebRequest request = WebRequest.Create(url);
                // Get the response.   
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.  
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.   
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.   
                string responseFromServer = reader.ReadToEnd();
                // Close the response.   
                response.Close();
                rtxt_box.Text = responseFromServer;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid url!");
            }
        }
    }
}
