namespace Lab2
{
    partial class Bai02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_read = new System.Windows.Forms.Button();
            this.rtxt_box = new System.Windows.Forms.RichTextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_tu = new System.Windows.Forms.TextBox();
            this.txt_kytu = new System.Windows.Forms.TextBox();
            this.txt_dong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_read.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btn_read.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_read.Location = new System.Drawing.Point(175, 60);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(443, 114);
            this.btn_read.TabIndex = 2;
            this.btn_read.Text = "Đọc file";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // rtxt_box
            // 
            this.rtxt_box.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_box.Location = new System.Drawing.Point(755, 73);
            this.rtxt_box.Name = "rtxt_box";
            this.rtxt_box.ReadOnly = true;
            this.rtxt_box.Size = new System.Drawing.Size(453, 701);
            this.rtxt_box.TabIndex = 4;
            this.rtxt_box.Text = "";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t.Font = new System.Drawing.Font("Cambria", 14F);
            this.t.ForeColor = System.Drawing.Color.Honeydew;
            this.t.Location = new System.Drawing.Point(30, 227);
            this.t.Name = "t";
            this.t.ReadOnly = true;
            this.t.Size = new System.Drawing.Size(207, 66);
            this.t.TabIndex = 5;
            this.t.Text = "Tên file";
            this.t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Honeydew;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_name.Location = new System.Drawing.Point(300, 227);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(422, 73);
            this.txt_name.TabIndex = 7;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(30, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(207, 66);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Url";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_url
            // 
            this.txt_url.BackColor = System.Drawing.Color.Honeydew;
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_url.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_url.Location = new System.Drawing.Point(300, 345);
            this.txt_url.Name = "txt_url";
            this.txt_url.ReadOnly = true;
            this.txt_url.Size = new System.Drawing.Size(422, 73);
            this.txt_url.TabIndex = 9;
            this.txt_url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox2.Location = new System.Drawing.Point(30, 460);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(207, 66);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Số dòng";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox3.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox3.Location = new System.Drawing.Point(30, 571);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(207, 66);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Số từ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox4.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox4.Location = new System.Drawing.Point(30, 678);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(207, 66);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Số ký tự";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tu
            // 
            this.txt_tu.BackColor = System.Drawing.Color.Honeydew;
            this.txt_tu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tu.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_tu.Location = new System.Drawing.Point(300, 564);
            this.txt_tu.Name = "txt_tu";
            this.txt_tu.ReadOnly = true;
            this.txt_tu.Size = new System.Drawing.Size(422, 73);
            this.txt_tu.TabIndex = 13;
            this.txt_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_kytu
            // 
            this.txt_kytu.BackColor = System.Drawing.Color.Honeydew;
            this.txt_kytu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kytu.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_kytu.Location = new System.Drawing.Point(300, 671);
            this.txt_kytu.Name = "txt_kytu";
            this.txt_kytu.ReadOnly = true;
            this.txt_kytu.Size = new System.Drawing.Size(422, 73);
            this.txt_kytu.TabIndex = 14;
            this.txt_kytu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dong
            // 
            this.txt_dong.BackColor = System.Drawing.Color.Honeydew;
            this.txt_dong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dong.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_dong.Location = new System.Drawing.Point(300, 453);
            this.txt_dong.Name = "txt_dong";
            this.txt_dong.ReadOnly = true;
            this.txt_dong.Size = new System.Drawing.Size(422, 73);
            this.txt_dong.TabIndex = 15;
            this.txt_dong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1274, 815);
            this.Controls.Add(this.txt_dong);
            this.Controls.Add(this.txt_kytu);
            this.Controls.Add(this.txt_tu);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.t);
            this.Controls.Add(this.rtxt_box);
            this.Controls.Add(this.btn_read);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.RichTextBox rtxt_box;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_tu;
        private System.Windows.Forms.TextBox txt_kytu;
        private System.Windows.Forms.TextBox txt_dong;
    }
}