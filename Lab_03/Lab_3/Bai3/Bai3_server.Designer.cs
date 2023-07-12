namespace Lab_3
{
    partial class Bai3_server
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
            this.rtxt_box = new System.Windows.Forms.RichTextBox();
            this.btn_listen = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_box
            // 
            this.rtxt_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtxt_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtxt_box.Location = new System.Drawing.Point(45, 39);
            this.rtxt_box.Name = "rtxt_box";
            this.rtxt_box.ReadOnly = true;
            this.rtxt_box.Size = new System.Drawing.Size(935, 447);
            this.rtxt_box.TabIndex = 13;
            this.rtxt_box.Text = "";
            // 
            // btn_listen
            // 
            this.btn_listen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_listen.Location = new System.Drawing.Point(187, 531);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(270, 92);
            this.btn_listen.TabIndex = 14;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Enabled = false;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_exit.Location = new System.Drawing.Point(587, 531);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(270, 92);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Bai3_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 654);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.rtxt_box);
            this.Name = "Bai3_server";
            this.Text = "Bai3_server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_box;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.Button btn_exit;
    }
}