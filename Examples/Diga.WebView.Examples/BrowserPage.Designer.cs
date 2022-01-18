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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bnReload = new System.Windows.Forms.Button();
            this.bnGo = new System.Windows.Forms.Button();
            this.bnForward = new System.Windows.Forms.Button();
            this.bnBack = new System.Windows.Forms.Button();
            this.txtNavigation = new Diga.WebView.Examples.NavTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebView = new Diga.WebView2.WinForms.WebView();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.bnReload);
            this.topPanel.Controls.Add(this.bnGo);
            this.topPanel.Controls.Add(this.bnForward);
            this.topPanel.Controls.Add(this.bnBack);
            this.topPanel.Controls.Add(this.txtNavigation);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(582, 43);
            this.topPanel.TabIndex = 0;
            // 
            // bnReload
            // 
            this.bnReload.Font = new System.Drawing.Font("FontAwesome", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnReload.Location = new System.Drawing.Point(31, 8);
            this.bnReload.Name = "bnReload";
            this.bnReload.Size = new System.Drawing.Size(22, 23);
            this.bnReload.TabIndex = 4;
            this.bnReload.Text = "";
            this.bnReload.UseVisualStyleBackColor = true;
            this.bnReload.Click += new System.EventHandler(this.bnReload_Click);
            // 
            // bnGo
            // 
            this.bnGo.Font = new System.Drawing.Font("FontAwesome", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnGo.Location = new System.Drawing.Point(537, 8);
            this.bnGo.Name = "bnGo";
            this.bnGo.Size = new System.Drawing.Size(38, 23);
            this.bnGo.TabIndex = 3;
            this.bnGo.Text = "";
            this.bnGo.UseVisualStyleBackColor = true;
            this.bnGo.Click += new System.EventHandler(this.bnGo_Click);
            // 
            // bnForward
            // 
            this.bnForward.Font = new System.Drawing.Font("FontAwesome", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnForward.Location = new System.Drawing.Point(59, 8);
            this.bnForward.Name = "bnForward";
            this.bnForward.Size = new System.Drawing.Size(22, 23);
            this.bnForward.TabIndex = 2;
            this.bnForward.Text = "";
            this.bnForward.UseVisualStyleBackColor = true;
            this.bnForward.Click += new System.EventHandler(this.bnForward_Click);
            // 
            // bnBack
            // 
            this.bnBack.Font = new System.Drawing.Font("FontAwesome", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bnBack.Location = new System.Drawing.Point(3, 8);
            this.bnBack.Name = "bnBack";
            this.bnBack.Size = new System.Drawing.Size(22, 23);
            this.bnBack.TabIndex = 1;
            this.bnBack.Text = "";
            this.bnBack.UseVisualStyleBackColor = true;
            this.bnBack.Click += new System.EventHandler(this.bnBack_Click);
            // 
            // txtNavigation
            // 
            this.txtNavigation.Location = new System.Drawing.Point(87, 8);
            this.txtNavigation.Name = "txtNavigation";
            this.txtNavigation.Size = new System.Drawing.Size(444, 29);
            this.txtNavigation.TabIndex = 0;
            this.txtNavigation.SourceTextChanged += new System.EventHandler(this.txtNavigation_SourceTextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WebView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 310);
            this.panel1.TabIndex = 1;
            // 
            // WebView
            // 
            this.WebView.AreBrowserAcceleratorKeysEnabled = true;
            this.WebView.BackColor = System.Drawing.Color.Black;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WebView.DefaultContextMenusEnabled = true;
            this.WebView.DefaultScriptDialogsEnabled = true;
            this.WebView.DevToolsEnabled = true;
            this.WebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebView.EnableMonitoring = false;
            this.WebView.ForeColor = System.Drawing.Color.White;
            this.WebView.HtmlContent = null;
            this.WebView.IsGeneralAutoFillEnabled = true;
            this.WebView.IsPasswordAutosaveEnabled = true;
            this.WebView.IsScriptEnabled = true;
            this.WebView.IsStatusBarEnabled = true;
            this.WebView.IsWebMessageEnabled = true;
            this.WebView.IsZoomControlEnabled = true;
            this.WebView.Location = new System.Drawing.Point(0, 0);
            this.WebView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WebView.MonitoringFolder = null;
            this.WebView.MonitoringUrl = null;
            this.WebView.Name = "WebView";
            this.WebView.RemoteObjectsAllowed = true;
            this.WebView.Size = new System.Drawing.Size(582, 310);
            this.WebView.TabIndex = 0;
            this.WebView.Url = "http://www.google.de";
            this.WebView.ZoomFactor = 1D;
            this.WebView.NavigationCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs>(this.WebView_NavigationCompleted);
            // 
            // BrowserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Name = "BrowserPage";
            this.Size = new System.Drawing.Size(582, 353);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
