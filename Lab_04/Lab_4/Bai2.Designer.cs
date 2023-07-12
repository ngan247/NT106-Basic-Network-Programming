namespace Lab_4
{
    partial class Bai2
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
            this.rtxt_box = new System.Windows.Forms.RichTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(300, 64);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(767, 71);
            this.txt_url.TabIndex = 1;
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(1192, 64);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(324, 74);
            this.btn_get.TabIndex = 2;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // rtxt_box
            // 
            this.rtxt_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_box.Location = new System.Drawing.Point(50, 188);
            this.rtxt_box.Name = "rtxt_box";
            this.rtxt_box.ReadOnly = true;
            this.rtxt_box.Size = new System.Drawing.Size(1168, 707);
            this.rtxt_box.TabIndex = 3;
            this.rtxt_box.Text = "";
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(1266, 188);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(737, 707);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2038, 907);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.rtxt_box);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txt_url);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.RichTextBox rtxt_box;
        private System.Windows.Forms.ListView listView;
    }
}