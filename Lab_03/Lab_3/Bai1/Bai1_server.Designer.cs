namespace Lab_3
{
    partial class Bai1_server
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_listen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_server = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(134, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // txt_port
            // 
            this.txt_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_port.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_port.Location = new System.Drawing.Point(253, 24);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(254, 71);
            this.txt_port.TabIndex = 4;
            // 
            // btn_listen
            // 
            this.btn_listen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_listen.Location = new System.Drawing.Point(635, 28);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(270, 92);
            this.btn_listen.TabIndex = 7;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "Received message";
            // 
            // rtxt_server
            // 
            this.rtxt_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_server.Location = new System.Drawing.Point(82, 220);
            this.rtxt_server.Name = "rtxt_server";
            this.rtxt_server.ReadOnly = true;
            this.rtxt_server.Size = new System.Drawing.Size(856, 334);
            this.rtxt_server.TabIndex = 11;
            this.rtxt_server.Text = "";
            // 
            // Bai1_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 566);
            this.Controls.Add(this.rtxt_server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label2);
            this.Name = "Bai1_server";
            this.Text = "Bai1_server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_server;
    }
}