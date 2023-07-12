namespace Lab2
{
    partial class Bai04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_hien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10F);
            this.groupBox1.Location = new System.Drawing.Point(22, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1391, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin SV";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 72);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 123;
            this.dgv.RowTemplate.Height = 46;
            this.dgv.Size = new System.Drawing.Size(1385, 421);
            this.dgv.TabIndex = 0;
            this.dgv.Visible = false;
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(53, 582);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(393, 81);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Nhập dữ liệu";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(517, 582);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(306, 81);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu file";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_hien
            // 
            this.btn_hien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hien.Location = new System.Drawing.Point(944, 582);
            this.btn_hien.Name = "btn_hien";
            this.btn_hien.Size = new System.Drawing.Size(378, 81);
            this.btn_hien.TabIndex = 3;
            this.btn_hien.Text = "Hiện thông tin";
            this.btn_hien.UseVisualStyleBackColor = true;
            this.btn_hien.Click += new System.EventHandler(this.btn_hien_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 788);
            this.Controls.Add(this.btn_hien);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_hien;
    }
}