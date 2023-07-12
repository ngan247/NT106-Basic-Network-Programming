namespace Lab2
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
            this.rtxt_tinh = new System.Windows.Forms.RichTextBox();
            this.rtxt_kq = new System.Windows.Forms.RichTextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_tinh
            // 
            this.rtxt_tinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_tinh.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_tinh.Location = new System.Drawing.Point(49, 243);
            this.rtxt_tinh.Name = "rtxt_tinh";
            this.rtxt_tinh.ReadOnly = true;
            this.rtxt_tinh.Size = new System.Drawing.Size(453, 560);
            this.rtxt_tinh.TabIndex = 5;
            this.rtxt_tinh.Text = "";
            // 
            // rtxt_kq
            // 
            this.rtxt_kq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_kq.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_kq.Location = new System.Drawing.Point(649, 243);
            this.rtxt_kq.Name = "rtxt_kq";
            this.rtxt_kq.ReadOnly = true;
            this.rtxt_kq.Size = new System.Drawing.Size(453, 560);
            this.rtxt_kq.TabIndex = 6;
            this.rtxt_kq.Text = "";
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_read.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btn_read.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_read.Location = new System.Drawing.Point(58, 48);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(238, 114);
            this.btn_read.TabIndex = 7;
            this.btn_read.Text = "Đọc file";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_tinh
            // 
            this.btn_tinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tinh.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btn_tinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tinh.Location = new System.Drawing.Point(446, 48);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(238, 114);
            this.btn_tinh.TabIndex = 8;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = false;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_write.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btn_write.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_write.Location = new System.Drawing.Point(820, 48);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(238, 114);
            this.btn_write.TabIndex = 9;
            this.btn_write.Text = "Ghi file";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1192, 852);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.rtxt_kq);
            this.Controls.Add(this.rtxt_tinh);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.Load += new System.EventHandler(this.Bai03_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_tinh;
        private System.Windows.Forms.RichTextBox rtxt_kq;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_write;
    }
}