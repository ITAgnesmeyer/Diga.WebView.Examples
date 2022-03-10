namespace HTMLEditor
{
    partial class frmVSCode
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
            this.webView1 = new Diga.WebView2.WinForms.WebView();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.AreBrowserAcceleratorKeysEnabled = true;
            this.webView1.BackColor = System.Drawing.Color.Transparent;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.Empty;
            this.webView1.DefaultContextMenusEnabled = true;
            this.webView1.DefaultScriptDialogsEnabled = true;
            this.webView1.DevToolsEnabled = true;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.EnableMonitoring = false;
            this.webView1.HtmlContent = null;
            this.webView1.IsGeneralAutoFillEnabled = false;
            this.webView1.IsMuted = false;
            this.webView1.IsPasswordAutosaveEnabled = false;
            this.webView1.IsScriptEnabled = true;
            this.webView1.IsStatusBarEnabled = true;
            this.webView1.IsWebMessageEnabled = true;
            this.webView1.IsZoomControlEnabled = true;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webView1.MonitoringFolder = null;
            this.webView1.MonitoringUrl = null;
            this.webView1.Name = "webView1";
            this.webView1.RemoteObjectsAllowed = true;
            this.webView1.Size = new System.Drawing.Size(800, 450);
            this.webView1.TabIndex = 0;
            this.webView1.Url = "https://vscode.dev";
            this.webView1.ZoomFactor = 0D;
            // 
            // frmVSCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView1);
            this.Name = "frmVSCode";
            this.Text = "Visual Stuido Code";
            this.ResumeLayout(false);

        }

        #endregion

        private Diga.WebView2.WinForms.WebView webView1;
    }
}