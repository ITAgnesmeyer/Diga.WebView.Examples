namespace HtmlControlExample
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webViewMain = new Diga.WebView2.WinForms.WebView();
            this.SuspendLayout();
            // 
            // webViewMain
            // 
            this.webViewMain.AreBrowserAcceleratorKeysEnabled = true;
            this.webViewMain.BackColor = System.Drawing.Color.Transparent;
            this.webViewMain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewMain.DefaultContextMenusEnabled = false;
            this.webViewMain.DefaultScriptDialogsEnabled = true;
            this.webViewMain.DevToolsEnabled = true;
            this.webViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewMain.EnableMonitoring = false;
            this.webViewMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.webViewMain.HtmlContent = "<html><head></head><body></body></html>";
            this.webViewMain.IsGeneralAutoFillEnabled = false;
            this.webViewMain.IsMuted = false;
            this.webViewMain.IsPasswordAutosaveEnabled = false;
            this.webViewMain.IsScriptEnabled = true;
            this.webViewMain.IsStatusBarEnabled = false;
            this.webViewMain.IsWebMessageEnabled = true;
            this.webViewMain.IsZoomControlEnabled = true;
            this.webViewMain.Location = new System.Drawing.Point(0, 0);
            this.webViewMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webViewMain.MonitoringFolder = null;
            this.webViewMain.MonitoringUrl = null;
            this.webViewMain.Name = "webViewMain";
            this.webViewMain.RemoteObjectsAllowed = true;
            this.webViewMain.Size = new System.Drawing.Size(800, 450);
            this.webViewMain.TabIndex = 0;
            this.webViewMain.Url = null;
            this.webViewMain.ZoomFactor = 0D;
            this.webViewMain.DocumentLoading += new System.EventHandler(this.webViewMain_DocumentLoading);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webViewMain);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Diga.WebView2.WinForms.WebView webViewMain;
    }
}