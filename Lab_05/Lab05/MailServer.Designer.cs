namespace Lab05
{
    partial class MailServer
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
            this.get = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.usermail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listmail = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.recent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // get
            // 
            this.get.BackColor = System.Drawing.Color.Navy;
            this.get.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.get.ForeColor = System.Drawing.Color.White;
            this.get.Location = new System.Drawing.Point(1784, 106);
            this.get.Margin = new System.Windows.Forms.Padding(7);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(349, 109);
            this.get.TabIndex = 21;
            this.get.Text = "Get";
            this.get.UseVisualStyleBackColor = false;
            this.get.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.password.ForeColor = System.Drawing.Color.Navy;
            this.password.Location = new System.Drawing.Point(435, 161);
            this.password.Margin = new System.Windows.Forms.Padding(7);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(1135, 63);
            this.password.TabIndex = 17;
            this.password.UseSystemPasswordChar = true;
            // 
            // usermail
            // 
            this.usermail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.usermail.ForeColor = System.Drawing.Color.Navy;
            this.usermail.Location = new System.Drawing.Point(435, 65);
            this.usermail.Margin = new System.Windows.Forms.Padding(7);
            this.usermail.Name = "usermail";
            this.usermail.Size = new System.Drawing.Size(1135, 63);
            this.usermail.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(140, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 51);
            this.label5.TabIndex = 15;
            this.label5.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(359, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 51);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(140, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 51);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(140, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email:";
            // 
            // listmail
            // 
            this.listmail.HideSelection = false;
            this.listmail.Location = new System.Drawing.Point(368, 386);
            this.listmail.Margin = new System.Windows.Forms.Padding(7);
            this.listmail.Name = "listmail";
            this.listmail.Size = new System.Drawing.Size(2080, 587);
            this.listmail.TabIndex = 22;
            this.listmail.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(990, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 51);
            this.label3.TabIndex = 23;
            this.label3.Text = "Recent:";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.total.ForeColor = System.Drawing.Color.Navy;
            this.total.Location = new System.Drawing.Point(506, 282);
            this.total.Margin = new System.Windows.Forms.Padding(7);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(399, 63);
            this.total.TabIndex = 24;
            // 
            // recent
            // 
            this.recent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.recent.ForeColor = System.Drawing.Color.Navy;
            this.recent.Location = new System.Drawing.Point(1171, 276);
            this.recent.Margin = new System.Windows.Forms.Padding(7);
            this.recent.Name = "recent";
            this.recent.Size = new System.Drawing.Size(399, 63);
            this.recent.TabIndex = 25;
            // 
            // MailServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2597, 1041);
            this.Controls.Add(this.recent);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listmail);
            this.Controls.Add(this.get);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usermail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MailServer";
            this.Text = "MailServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button get;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usermail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox recent;
    }
}