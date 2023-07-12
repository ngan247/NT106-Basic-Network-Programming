namespace Lab_4
{
    partial class Bai3
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.rtxt_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(39, 40);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(824, 71);
            this.txt_url.TabIndex = 1;
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(902, 40);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(324, 74);
            this.btn_get.TabIndex = 2;
            this.btn_get.Text = "Download";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(39, 145);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(824, 71);
            this.txt_path.TabIndex = 3;
            this.txt_path.Text = "E:\\file.html";
            // 
            // rtxt_box
            // 
            this.rtxt_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_box.Location = new System.Drawing.Point(39, 256);
            this.rtxt_box.Name = "rtxt_box";
            this.rtxt_box.ReadOnly = true;
            this.rtxt_box.Size = new System.Drawing.Size(1258, 487);
            this.rtxt_box.TabIndex = 4;
            this.rtxt_box.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 829);
            this.Controls.Add(this.rtxt_box);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txt_url);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.RichTextBox rtxt_box;
    }
}