using System.Windows.Forms;


namespace Diga.WebView.Examples
{
    partial class BrowserPage
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            topPanel = new Panel();
            bnReload = new Button();
            bnGo = new Button();
            bnForward = new Button();
            bnBack = new Button();
            txtNavigation = new NavTextBox();
            panel1 = new Panel();
            WebView = new WebView2.WinForms.WebView();
            topPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(bnReload);
            topPanel.Controls.Add(bnGo);
            topPanel.Controls.Add(bnForward);
            topPanel.Controls.Add(bnBack);
            topPanel.Controls.Add(txtNavigation);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(582, 43);
            topPanel.TabIndex = 0;
            // 
            // bnReload
            // 
            bnReload.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            bnReload.Location = new System.Drawing.Point(31, 8);
            bnReload.Name = "bnReload";
            bnReload.Size = new System.Drawing.Size(22, 23);
            bnReload.TabIndex = 4;
            bnReload.Text = "";
            bnReload.UseVisualStyleBackColor = true;
            bnReload.Click += bnReload_Click;
            // 
            // bnGo
            // 
            bnGo.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            bnGo.Location = new System.Drawing.Point(537, 8);
            bnGo.Name = "bnGo";
            bnGo.Size = new System.Drawing.Size(38, 23);
            bnGo.TabIndex = 3;
            bnGo.Text = "";
            bnGo.UseVisualStyleBackColor = true;
            bnGo.Click += bnGo_Click;
            // 
            // bnForward
            // 
            bnForward.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            bnForward.Location = new System.Drawing.Point(59, 8);
            bnForward.Name = "bnForward";
            bnForward.Size = new System.Drawing.Size(22, 23);
            bnForward.TabIndex = 2;
            bnForward.Text = "⏵";
            bnForward.UseVisualStyleBackColor = true;
            bnForward.Click += bnForward_Click;
            // 
            // bnBack
            // 
            bnBack.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            bnBack.Location = new System.Drawing.Point(3, 8);
            bnBack.Name = "bnBack";
            bnBack.Size = new System.Drawing.Size(22, 23);
            bnBack.TabIndex = 1;
            bnBack.Text = "⏴";
            bnBack.UseVisualStyleBackColor = true;
            bnBack.Click += bnBack_Click;
            // 
            // txtNavigation
            // 
            txtNavigation.Location = new System.Drawing.Point(87, 8);
            txtNavigation.Name = "txtNavigation";
            txtNavigation.Size = new System.Drawing.Size(444, 29);
            txtNavigation.TabIndex = 0;
            txtNavigation.SourceTextChanged += txtNavigation_SourceTextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(WebView);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(582, 310);
            panel1.TabIndex = 1;
            // 
            // WebView
            // 
            WebView.AreBrowserAcceleratorKeysEnabled = true;
            WebView.BackColor = System.Drawing.Color.Black;
            WebView.CgiExeFile = null;
            WebView.CgiFileExtensions = null;
            WebView.CgiMoitoringFolder = null;
            WebView.CgiMoitoringUrl = null;
            WebView.DefaultBackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            WebView.DefaultContextMenusEnabled = true;
            WebView.DefaultScriptDialogsEnabled = true;
            WebView.DevToolsEnabled = true;
            WebView.Dock = DockStyle.Fill;
            WebView.EnableCgi = false;
            WebView.EnableMonitoring = false;
            WebView.ForeColor = System.Drawing.Color.White;
            WebView.HtmlContent = null;
            WebView.IsGeneralAutoFillEnabled = true;
            WebView.IsMuted = false;
            WebView.IsPasswordAutosaveEnabled = true;
            WebView.IsScriptEnabled = true;
            WebView.IsStatusBarEnabled = true;
            WebView.IsWebMessageEnabled = true;
            WebView.IsZoomControlEnabled = true;
            WebView.Location = new System.Drawing.Point(0, 0);
            WebView.Margin = new Padding(4, 3, 4, 3);
            WebView.MonitoringFolder = null;
            WebView.MonitoringUrl = null;
            WebView.Name = "WebView";
            WebView.RemoteObjectsAllowed = true;
            WebView.SchemeRegistrations = null;
            WebView.Size = new System.Drawing.Size(582, 310);
            WebView.TabIndex = 0;
            WebView.Url = "http://www.google.de";
            WebView.ZoomFactor = 1D;
            WebView.NavigationCompleted += WebView_NavigationCompleted;
            // 
            // BrowserPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Name = "BrowserPage";
            Size = new System.Drawing.Size(582, 353);
            topPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel panel1;
        private NavTextBox txtNavigation;
        private Button bnBack;
        private WebView2.WinForms.WebView WebView;
        private Button bnGo;
        private Button bnForward;
        private Button bnReload;
    }
}
