﻿namespace HTMLEditor
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webViewCode = new Diga.WebView2.WinForms.WebView();
            this.webViewPreView = new Diga.WebView2.WinForms.WebView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vSCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decodeEncodeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 520);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webViewCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webViewPreView);
            this.splitContainer1.Size = new System.Drawing.Size(877, 520);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // webViewCode
            // 
            this.webViewCode.AreBrowserAcceleratorKeysEnabled = true;
            this.webViewCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.webViewCode.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.webViewCode.DefaultContextMenusEnabled = false;
            this.webViewCode.DefaultScriptDialogsEnabled = true;
            this.webViewCode.DevToolsEnabled = true;
            this.webViewCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewCode.EnableMonitoring = false;
            this.webViewCode.HtmlContent = null;
            this.webViewCode.IsGeneralAutoFillEnabled = false;
            this.webViewCode.IsMuted = false;
            this.webViewCode.IsPasswordAutosaveEnabled = false;
            this.webViewCode.IsScriptEnabled = true;
            this.webViewCode.IsStatusBarEnabled = false;
            this.webViewCode.IsWebMessageEnabled = true;
            this.webViewCode.IsZoomControlEnabled = true;
            this.webViewCode.Location = new System.Drawing.Point(0, 0);
            this.webViewCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webViewCode.MonitoringFolder = null;
            this.webViewCode.MonitoringUrl = null;
            this.webViewCode.Name = "webViewCode";
            this.webViewCode.RemoteObjectsAllowed = true;
            this.webViewCode.Size = new System.Drawing.Size(400, 520);
            this.webViewCode.TabIndex = 0;
            this.webViewCode.Url = "";
            this.webViewCode.ZoomFactor = 0D;
            this.webViewCode.NavigationCompleted += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs>(this.webViewCode_NavigationCompleted);
            this.webViewCode.WebViewCreated += new System.EventHandler(this.webViewCode_WebViewCreated);
            // 
            // webViewPreView
            // 
            this.webViewPreView.AreBrowserAcceleratorKeysEnabled = true;
            this.webViewPreView.BackColor = System.Drawing.Color.White;
            this.webViewPreView.DefaultBackgroundColor = System.Drawing.Color.Empty;
            this.webViewPreView.DefaultContextMenusEnabled = true;
            this.webViewPreView.DefaultScriptDialogsEnabled = true;
            this.webViewPreView.DevToolsEnabled = true;
            this.webViewPreView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewPreView.EnableMonitoring = false;
            this.webViewPreView.HtmlContent = null;
            this.webViewPreView.IsGeneralAutoFillEnabled = false;
            this.webViewPreView.IsMuted = false;
            this.webViewPreView.IsPasswordAutosaveEnabled = false;
            this.webViewPreView.IsScriptEnabled = true;
            this.webViewPreView.IsStatusBarEnabled = false;
            this.webViewPreView.IsWebMessageEnabled = true;
            this.webViewPreView.IsZoomControlEnabled = true;
            this.webViewPreView.Location = new System.Drawing.Point(0, 0);
            this.webViewPreView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webViewPreView.MonitoringFolder = null;
            this.webViewPreView.MonitoringUrl = null;
            this.webViewPreView.Name = "webViewPreView";
            this.webViewPreView.RemoteObjectsAllowed = true;
            this.webViewPreView.Size = new System.Drawing.Size(467, 520);
            this.webViewPreView.TabIndex = 0;
            this.webViewPreView.Url = null;
            this.webViewPreView.ZoomFactor = 0D;
            this.webViewPreView.PermissionRequested += new System.EventHandler<Diga.WebView2.Wrapper.EventArguments.PermissionRequestedEventArgs>(this.webViewPreView_PermissionRequested);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contentToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contentToolStripMenuItem
            // 
            this.contentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showContentToolStripMenuItem,
            this.decodeEncodeTestToolStripMenuItem});
            this.contentToolStripMenuItem.Name = "contentToolStripMenuItem";
            this.contentToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.contentToolStripMenuItem.Text = "Content";
            // 
            // showContentToolStripMenuItem
            // 
            this.showContentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodedToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.directToolStripMenuItem});
            this.showContentToolStripMenuItem.Name = "showContentToolStripMenuItem";
            this.showContentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showContentToolStripMenuItem.Text = "ShowContent";
            // 
            // encodedToolStripMenuItem
            // 
            this.encodedToolStripMenuItem.Name = "encodedToolStripMenuItem";
            this.encodedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encodedToolStripMenuItem.Text = "Encoded";
            this.encodedToolStripMenuItem.Click += new System.EventHandler(this.encodedToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // directToolStripMenuItem
            // 
            this.directToolStripMenuItem.Name = "directToolStripMenuItem";
            this.directToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directToolStripMenuItem.Text = "Direct";
            this.directToolStripMenuItem.Click += new System.EventHandler(this.directToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vSCodeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // vSCodeToolStripMenuItem
            // 
            this.vSCodeToolStripMenuItem.Name = "vSCodeToolStripMenuItem";
            this.vSCodeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.vSCodeToolStripMenuItem.Text = "VS-Code";
            this.vSCodeToolStripMenuItem.Click += new System.EventHandler(this.vSCodeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 18);
            this.panel2.TabIndex = 3;
            // 
            // decodeEncodeTestToolStripMenuItem
            // 
            this.decodeEncodeTestToolStripMenuItem.Name = "decodeEncodeTestToolStripMenuItem";
            this.decodeEncodeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decodeEncodeTestToolStripMenuItem.Text = "DecodeEncode-Test";
            this.decodeEncodeTestToolStripMenuItem.Click += new System.EventHandler(this.decodeEncodeTestToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Code-Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Diga.WebView2.WinForms.WebView webViewCode;
        private Diga.WebView2.WinForms.WebView webViewPreView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem contentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vSCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeEncodeTestToolStripMenuItem;
    }
}
