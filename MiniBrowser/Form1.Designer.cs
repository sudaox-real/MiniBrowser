
namespace MiniBrowser
{
    partial class Form1
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
            this.url = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(572, 4);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(145, 20);
            this.url.TabIndex = 0;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(723, 2);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 1;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(12, 30);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(776, 408);
            this.browser.TabIndex = 2;
            this.browser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(491, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(75, 23);
            this.history.TabIndex = 3;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = true;
            this.history.Visible = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.history);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.go);
            this.Controls.Add(this.url);
            this.Name = "Form1";
            this.Text = "MiniBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button history;
    }
}

