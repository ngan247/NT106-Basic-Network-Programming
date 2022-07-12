namespace Lab_01
{
    partial class Bai01
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
            this.btn_tong = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tong
            // 
            this.btn_tong.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tong.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_tong.Location = new System.Drawing.Point(563, 448);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(315, 95);
            this.btn_tong.TabIndex = 0;
            this.btn_tong.Text = "Tính tổng";
            this.btn_tong.UseVisualStyleBackColor = false;
            this.btn_tong.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(429, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(593, 73);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " Tính tổng 2 số nguyên";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox2.Location = new System.Drawing.Point(28, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(315, 73);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = " Số thứ nhất";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox3.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox3.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox3.Location = new System.Drawing.Point(28, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(315, 73);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = " Số thứ hai";
            // 
            // txt_so1
            // 
            this.txt_so1.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_so1.Location = new System.Drawing.Point(454, 185);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(870, 73);
            this.txt_so1.TabIndex = 4;
            // 
            // txt_so2
            // 
            this.txt_so2.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_so2.Location = new System.Drawing.Point(454, 306);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(870, 73);
            this.txt_so2.TabIndex = 5;
            // 
            // txt_sum
            // 
            this.txt_sum.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_sum.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_sum.Location = new System.Drawing.Point(28, 579);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.ReadOnly = true;
            this.txt_sum.Size = new System.Drawing.Size(1344, 73);
            this.txt_sum.TabIndex = 6;
            this.txt_sum.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_thoat.Location = new System.Drawing.Point(840, 689);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(315, 95);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xoa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_xoa.Location = new System.Drawing.Point(206, 689);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(315, 95);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = " Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1421, 849);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_tong);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
    }
}