namespace Lab_3
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
            this.btn_bai1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_bai4 = new System.Windows.Forms.Button();
            this.btn_bai3 = new System.Windows.Forms.Button();
            this.btn_bai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_bai1
            // 
            this.btn_bai1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai1.Location = new System.Drawing.Point(123, 154);
            this.btn_bai1.Name = "btn_bai1";
            this.btn_bai1.Size = new System.Drawing.Size(358, 94);
            this.btn_bai1.TabIndex = 0;
            this.btn_bai1.Text = "Bài 1";
            this.btn_bai1.UseVisualStyleBackColor = true;
            this.btn_bai1.Click += new System.EventHandler(this.btn_bai1_Click);
            // 
            // btn_bai4
            // 
            this.btn_bai4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai4.Location = new System.Drawing.Point(658, 362);
            this.btn_bai4.Name = "btn_bai4";
            this.btn_bai4.Size = new System.Drawing.Size(358, 94);
            this.btn_bai4.TabIndex = 1;
            this.btn_bai4.Text = "Bài 4";
            this.btn_bai4.UseVisualStyleBackColor = true;
            this.btn_bai4.Click += new System.EventHandler(this.btn_bai4_Click);
            // 
            // btn_bai3
            // 
            this.btn_bai3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai3.Location = new System.Drawing.Point(123, 362);
            this.btn_bai3.Name = "btn_bai3";
            this.btn_bai3.Size = new System.Drawing.Size(358, 94);
            this.btn_bai3.TabIndex = 2;
            this.btn_bai3.Text = "Bài 3";
            this.btn_bai3.UseVisualStyleBackColor = true;
            this.btn_bai3.Click += new System.EventHandler(this.btn_bai3_Click);
            // 
            // btn_bai2
            // 
            this.btn_bai2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bai2.Location = new System.Drawing.Point(658, 154);
            this.btn_bai2.Name = "btn_bai2";
            this.btn_bai2.Size = new System.Drawing.Size(358, 94);
            this.btn_bai2.TabIndex = 3;
            this.btn_bai2.Text = "Bài 2";
            this.btn_bai2.UseVisualStyleBackColor = true;
            this.btn_bai2.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 660);
            this.Controls.Add(this.btn_bai2);
            this.Controls.Add(this.btn_bai3);
            this.Controls.Add(this.btn_bai4);
            this.Controls.Add(this.btn_bai1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bai1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_bai4;
        private System.Windows.Forms.Button btn_bai3;
        private System.Windows.Forms.Button btn_bai2;
    }
}

