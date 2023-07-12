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
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab2
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            new Bai04_b().ShowDialog();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string content;
            /* mở hộp chọn file */
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file";
            ofd.Filter = "TXT files|*.txt"; // chỉ mở file .txt
            ofd.InitialDirectory = @"E:\"; // chọn đường dẫn ban đầu
            ofd.ShowDialog();

            /* đọc file */
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            content = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Họ tên");
                table.Columns.Add("MSSV");
                table.Columns.Add("Số điện thoại");
                table.Columns.Add("Điểm môn toán");
                table.Columns.Add("Điểm môn văn");
                table.Columns.Add("ĐTB");
                /* lưu giá trị vào rows của table và tính đtb */
                content = content.Replace("\n", ";");
                string[] str = content.Split(';');
                float t;
                for (int i = 0; i < str.Length - 4; i += 5)
                {
                    t = (float.Parse(str[i + 3]) + float.Parse(str[i + 4])) / 2;
                    table.Rows.Add(str[i], str[i + 1], str[i + 2], str[i + 3], str[i + 4],
                        t.ToString("#.#")); // in 1 chữ số thập phân 
                }

                /* xuất file excel */
                // mở hộp lưu file
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Export excel";
                sfd.FileName = "bai4.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //ExportExcel(sfd.FileName);
                        Excel.Application app = new Excel.Application();
                        app.Application.Workbooks.Add(Type.Missing);
                        // tên column
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            app.Cells[1, i + 1] = table.Columns[i].ToString();
                        }
                        // giá trị các dòng
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            for (int j = 0; j < table.Columns.Count; j++)
                            {
                                app.Cells[i + 2, j + 1] = table.Rows[i].ItemArray[j].ToString();
                            }
                        }
                        app.Columns.AutoFit();
                        app.ActiveWorkbook.SaveCopyAs(sfd.FileName);
                        app.ActiveWorkbook.Saved = true;
                        MessageBox.Show("Xuất file thành công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xuất file không thành công");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn file đúng định dạng!");
            }
        }

        private void btn_hien_Click(object sender, EventArgs e)
        {
            dgv.Refresh();
            /* mở hộp chọn file */
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file";
            ofd.Filter = "Excel (*.xlsx)|*.xlsx"; // chỉ mở file .txt
            ofd.InitialDirectory = @"E:\"; // chọn đường dẫn ban đầu
            ofd.ShowDialog();

            using (ExcelPackage epack = new ExcelPackage(new FileInfo(ofd.FileName)))
            {
                ExcelWorksheet ws = epack.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = ws.Dimension.Start.Column; i <= ws.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(ws.Cells[1, i].Value.ToString());
                }
                for (int i = ws.Dimension.Start.Row + 1; i <= ws.Dimension.End.Row; i++)
                {
                    List<string> rlist = new List<string>();
                    for (int j = ws.Dimension.Start.Column; j <= ws.Dimension.End.Column; j++)
                    {
                        rlist.Add(ws.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(rlist.ToArray());

                }
                dgv.DataSource = dataTable;
                dgv.Visible = true;
            }
        }

    }
}
