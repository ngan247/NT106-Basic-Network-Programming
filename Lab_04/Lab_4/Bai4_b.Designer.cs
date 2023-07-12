namespace Lab_4
{
    partial class Bai4_b
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
            this.rtxt_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(80, 38);
            this.txt_url.Name = "txt_url";
            this.txt_url.ReadOnly = true;
            this.txt_url.Size = new System.Drawing.Size(1373, 71);
            this.txt_url.TabIndex = 3;
            // 
            // rtxt_box
            // 
            this.rtxt_box.Location = new System.Drawing.Point(12, 132);
            this.rtxt_box.Name = "rtxt_box";
            this.rtxt_box.ReadOnly = true;
            this.rtxt_box.Size = new System.Drawing.Size(1500, 742);
            this.rtxt_box.TabIndex = 10;
            this.rtxt_box.Text = "";
            // 
            // Bai4_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 904);
            this.Controls.Add(this.rtxt_box);
            this.Controls.Add(this.txt_url);
            this.Name = "Bai4_b";
            this.Text = "Bai4_b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.RichTextBox rtxt_box;
    }
}