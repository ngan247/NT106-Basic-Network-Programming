namespace Lab_3
{
    partial class Bai1_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_client = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP remote host";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ip.Location = new System.Drawing.Point(56, 85);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(405, 71);
            this.txt_ip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(623, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txt_port
            // 
            this.txt_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_port.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_port.Location = new System.Drawing.Point(632, 85);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(254, 71);
            this.txt_port.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // rtxt_client
            // 
            this.rtxt_client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_client.Location = new System.Drawing.Point(56, 250);
            this.rtxt_client.Name = "rtxt_client";
            this.rtxt_client.Size = new System.Drawing.Size(830, 188);
            this.rtxt_client.TabIndex = 5;
            this.rtxt_client.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_send.Location = new System.Drawing.Point(338, 473);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(270, 67);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Bai1_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1047, 566);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.rtxt_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai1_client";
            this.Text = "UDP Client";
            this.Load += new System.EventHandler(this.Bai1_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_client;
        private System.Windows.Forms.Button btn_send;
    }
}