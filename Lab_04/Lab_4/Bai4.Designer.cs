namespace Lab_4
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(261, 23);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(1373, 71);
            this.txt_url.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1688, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(219, 74);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(35, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 80);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_forward.BackgroundImage")));
            this.btn_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_forward.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forward.Location = new System.Drawing.Point(148, 23);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(88, 80);
            this.btn_forward.TabIndex = 5;
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // web_browser
            // 
            this.web_browser.Location = new System.Drawing.Point(3, 150);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(2027, 804);
            this.web_browser.TabIndex = 6;
            this.web_browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.web_browser_Navigated);
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_view.Location = new System.Drawing.Point(482, 995);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(431, 80);
            this.btn_view.TabIndex = 7;
            this.btn_view.Text = "View source";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_download
            // 
            this.btn_download.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_download.Location = new System.Drawing.Point(12, 995);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(431, 80);
            this.btn_download.TabIndex = 8;
            this.btn_download.Text = "Download source";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2030, 1279);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.web_browser);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_url);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_download;
    }
}