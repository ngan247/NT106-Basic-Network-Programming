﻿namespace Lab05
{
    partial class SendMailViaGmail
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
            this.bcccheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.RichTextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.mailto = new System.Windows.Forms.TextBox();
            this.mailfrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attachbutton = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bcccheck
            // 
            this.bcccheck.AutoSize = true;
            this.bcccheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bcccheck.Location = new System.Drawing.Point(1574, 135);
            this.bcccheck.Margin = new System.Windows.Forms.Padding(7);
            this.bcccheck.Name = "bcccheck";
            this.bcccheck.Size = new System.Drawing.Size(42, 41);
            this.bcccheck.TabIndex = 25;
            this.bcccheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1339, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 51);
            this.label6.TabIndex = 24;
            this.label6.Text = "BCC?";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Navy;
            this.send.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(1698, 232);
            this.send.Margin = new System.Windows.Forms.Padding(7);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(446, 99);
            this.send.TabIndex = 23;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mail.ForeColor = System.Drawing.Color.Navy;
            this.mail.Location = new System.Drawing.Point(261, 494);
            this.mail.Margin = new System.Windows.Forms.Padding(7);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(1878, 663);
            this.mail.TabIndex = 22;
            this.mail.Text = "";
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.subject.ForeColor = System.Drawing.Color.Navy;
            this.subject.Location = new System.Drawing.Point(261, 390);
            this.subject.Margin = new System.Windows.Forms.Padding(7);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(1878, 63);
            this.subject.TabIndex = 21;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password.ForeColor = System.Drawing.Color.Navy;
            this.password.Location = new System.Drawing.Point(1551, 20);
            this.password.Margin = new System.Windows.Forms.Padding(7);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(588, 63);
            this.password.TabIndex = 20;
            this.password.UseSystemPasswordChar = true;
            // 
            // mailto
            // 
            this.mailto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailto.ForeColor = System.Drawing.Color.Navy;
            this.mailto.Location = new System.Drawing.Point(261, 119);
            this.mailto.Margin = new System.Windows.Forms.Padding(7);
            this.mailto.Name = "mailto";
            this.mailto.Size = new System.Drawing.Size(1013, 63);
            this.mailto.TabIndex = 19;
            // 
            // mailfrom
            // 
            this.mailfrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailfrom.ForeColor = System.Drawing.Color.Navy;
            this.mailfrom.Location = new System.Drawing.Point(261, 20);
            this.mailfrom.Margin = new System.Windows.Forms.Padding(7);
            this.mailfrom.Name = "mailfrom";
            this.mailfrom.Size = new System.Drawing.Size(1013, 63);
            this.mailfrom.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(76, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 51);
            this.label5.TabIndex = 17;
            this.label5.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(76, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 51);
            this.label4.TabIndex = 16;
            this.label4.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1339, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 51);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(76, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 51);
            this.label2.TabIndex = 14;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "From:";
            // 
            // attachbutton
            // 
            this.attachbutton.BackColor = System.Drawing.Color.Navy;
            this.attachbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.attachbutton.ForeColor = System.Drawing.Color.White;
            this.attachbutton.Location = new System.Drawing.Point(261, 251);
            this.attachbutton.Margin = new System.Windows.Forms.Padding(7);
            this.attachbutton.Name = "attachbutton";
            this.attachbutton.Size = new System.Drawing.Size(306, 63);
            this.attachbutton.TabIndex = 26;
            this.attachbutton.Text = "Attachment";
            this.attachbutton.UseVisualStyleBackColor = false;
            this.attachbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // attach
            // 
            this.attach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.attach.ForeColor = System.Drawing.Color.Navy;
            this.attach.Location = new System.Drawing.Point(581, 251);
            this.attach.Margin = new System.Windows.Forms.Padding(7);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(1035, 63);
            this.attach.TabIndex = 27;
            // 
            // SendMailViaGmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2220, 1176);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.attachbutton);
            this.Controls.Add(this.bcccheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.send);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mailto);
            this.Controls.Add(this.mailfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMailViaGmail";
            this.Text = "SendMailViaGmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bcccheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox mail;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox mailto;
        private System.Windows.Forms.TextBox mailfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attachbutton;
        private System.Windows.Forms.TextBox attach;
    }
}