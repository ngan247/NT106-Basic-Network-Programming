namespace Lab_3
{
    partial class Client
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mess = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.listview = new System.Windows.Forms.ListView();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(66, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your name";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_name.Location = new System.Drawing.Point(306, 459);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(274, 71);
            this.txt_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(66, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message";
            // 
            // txt_mess
            // 
            this.txt_mess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mess.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_mess.Location = new System.Drawing.Point(306, 573);
            this.txt_mess.Name = "txt_mess";
            this.txt_mess.Size = new System.Drawing.Size(863, 71);
            this.txt_mess.TabIndex = 9;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_send.Location = new System.Drawing.Point(653, 459);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(216, 80);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // listview
            // 
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(50, 22);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(1119, 346);
            this.listview.TabIndex = 12;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(929, 459);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(216, 80);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button2_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 739);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_mess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Chat room";
            this.Load += new System.EventHandler(this.Bai4_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mess;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Button btn_login;
    }
}