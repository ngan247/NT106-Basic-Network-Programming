namespace Lab_01
{
    partial class Bai03
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_so = new System.Windows.Forms.TextBox();
            this.btn_doc = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(504, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(227, 73);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = " Đọc số";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox2.Location = new System.Drawing.Point(52, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(714, 73);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Nhập số nguyên từ 0 đến 9";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_so
            // 
            this.txt_so.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_so.Location = new System.Drawing.Point(875, 170);
            this.txt_so.Name = "txt_so";
            this.txt_so.Size = new System.Drawing.Size(308, 73);
            this.txt_so.TabIndex = 7;
            // 
            // btn_doc
            // 
            this.btn_doc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_doc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_doc.Location = new System.Drawing.Point(52, 376);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(315, 95);
            this.btn_doc.TabIndex = 10;
            this.btn_doc.Text = "Đọc";
            this.btn_doc.UseVisualStyleBackColor = false;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xoa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_xoa.Location = new System.Drawing.Point(52, 522);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(315, 95);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_thoat.Location = new System.Drawing.Point(52, 657);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(315, 95);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_doc
            // 
            this.txt_doc.BackColor = System.Drawing.Color.Pink;
            this.txt_doc.Font = new System.Drawing.Font("Cambria", 14F);
            this.txt_doc.Location = new System.Drawing.Point(618, 385);
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.ReadOnly = true;
            this.txt_doc.Size = new System.Drawing.Size(524, 73);
            this.txt_doc.TabIndex = 13;
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1257, 827);
            this.Controls.Add(this.txt_doc);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_doc);
            this.Controls.Add(this.txt_so);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_so;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_doc;
    }
}