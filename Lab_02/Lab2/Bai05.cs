using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab2
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            listView.Clear();
            
            // mở hộp chọn folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo tên cột
                listView.View = View.Details;
                listView.Columns.Add("Tên file");
                listView.Columns.Add("Kích thước");
                listView.Columns.Add("Đuôi mở rộng");
                listView.Columns.Add("Ngày tạo");

                // lấy thông tin các files trong folder đã chọn
                string[] filesarr = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (string file in filesarr)
                {
                    FileInfo fi = new FileInfo(file);
                    ListViewItem item = new ListViewItem();
                    item.Text = fi.Name;
                    item.SubItems.Add(fi.Length.ToString());
                    item.SubItems.Add(fi.Extension);
                    item.SubItems.Add(fi.CreationTime.ToString());
                    listView.Items.Add(item);
                }
            }
            // Autosize cho columns
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = -2;
            }

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
