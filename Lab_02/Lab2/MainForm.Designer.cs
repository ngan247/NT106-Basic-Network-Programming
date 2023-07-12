namespace Lab2
{
    partial class MainForm
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
            this.btn_b1 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.btn_b3 = new System.Windows.Forms.Button();
            this.btn_b4 = new System.Windows.Forms.Button();
            this.btn_b5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_b1
            // 
            this.btn_b1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_b1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_b1.Location = new System.Drawing.Point(161, 115);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(299, 114);
            this.btn_b1.TabIndex = 0;
            this.btn_b1.Text = "Bài 1";
            this.btn_b1.UseVisualStyleBackColor = false;
            this.btn_b1.Click += new System.EventHandler(this.btn_bt1_Click);
            // 
            // btn_b2
            // 
            this.btn_b2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_b2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_b2.Location = new System.Drawing.Point(714, 115);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(299, 114);
            this.btn_b2.TabIndex = 1;
            this.btn_b2.Text = "Bài 2";
            this.btn_b2.UseVisualStyleBackColor = false;
            this.btn_b2.Click += new System.EventHandler(this.btn_b2_Click);
            // 
            // btn_b3
            // 
            this.btn_b3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_b3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_b3.Location = new System.Drawing.Point(161, 324);
            this.btn_b3.Name = "btn_b3";
            this.btn_b3.Size = new System.Drawing.Size(299, 114);
            this.btn_b3.TabIndex = 2;
            this.btn_b3.Text = "Bài 3";
            this.btn_b3.UseVisualStyleBackColor = false;
            this.btn_b3.Click += new System.EventHandler(this.btn_b3_Click);
            // 
            // btn_b4
            // 
            this.btn_b4.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_b4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_b4.Location = new System.Drawing.Point(714, 324);
            this.btn_b4.Name = "btn_b4";
            this.btn_b4.Size = new System.Drawing.Size(299, 114);
            this.btn_b4.TabIndex = 3;
            this.btn_b4.Text = "Bài 4";
            this.btn_b4.UseVisualStyleBackColor = false;
            this.btn_b4.Click += new System.EventHandler(this.btn_b4_Click);
            // 
            // btn_b5
            // 
            this.btn_b5.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_b5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_b5.Location = new System.Drawing.Point(161, 523);
            this.btn_b5.Name = "btn_b5";
            this.btn_b5.Size = new System.Drawing.Size(299, 114);
            this.btn_b5.TabIndex = 4;
            this.btn_b5.Text = "Bài 5";
            this.btn_b5.UseVisualStyleBackColor = false;
            this.btn_b5.Click += new System.EventHandler(this.btn_b5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1219, 768);
            this.Controls.Add(this.btn_b5);
            this.Controls.Add(this.btn_b4);
            this.Controls.Add(this.btn_b3);
            this.Controls.Add(this.btn_b2);
            this.Controls.Add(this.btn_b1);
            this.Name = "MainForm";
            this.Text = "Lab 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.Button btn_b3;
        private System.Windows.Forms.Button btn_b4;
        private System.Windows.Forms.Button btn_b5;
    }
}

