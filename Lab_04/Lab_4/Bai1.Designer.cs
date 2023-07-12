namespace Lab_4
{
    partial class Bai1
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
            this.txt_box = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.rtxt_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_box
            // 
            this.txt_box.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box.Location = new System.Drawing.Point(52, 79);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(767, 71);
            this.txt_box.TabIndex = 0;
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(848, 79);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(324, 74);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // rtxt_box
            // 
            this.rtxt_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_box.Location = new System.Drawing.Point(52, 210);
            this.rtxt_box.Name = "rtxt_box";
            this.rtxt_box.ReadOnly = true;
            this.rtxt_box.Size = new System.Drawing.Size(1120, 487);
            this.rtxt_box.TabIndex = 2;
            this.rtxt_box.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 774);
            this.Controls.Add(this.rtxt_box);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txt_box);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.RichTextBox rtxt_box;
    }
}