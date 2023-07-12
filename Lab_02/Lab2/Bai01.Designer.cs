namespace Lab2
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
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.txt_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_read.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_read.Location = new System.Drawing.Point(78, 186);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(299, 114);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Đọc file";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_write.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_write.Location = new System.Drawing.Point(78, 436);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(299, 114);
            this.btn_write.TabIndex = 2;
            this.btn_write.Text = "Ghi file";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // txt_box
            // 
            this.txt_box.Location = new System.Drawing.Point(475, 73);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(667, 605);
            this.txt_box.TabIndex = 3;
            this.txt_box.Text = "";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1236, 805);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.RichTextBox txt_box;
    }
}