using System.Windows.Forms;

namespace Diga.WebView.Examples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void tabControl1_Click(object sender, System.EventArgs e)
        {
            if (this.tabControl1.SelectedIndex != this.tabControl1.TabPages.Count - 1)
                return;
            int count = this.tabControl1.TabPages.Count;
            string tabKey = "tab" + count;
            this.tabControl1.TabPages.Insert(0, tabKey);
            var tab = this.tabControl1.TabPages[0];
            BrowserPage p = new BrowserPage();
            p.SourceChange += (s, ex) =>
            {
                tab.Text = ex.Url;
            };
            p.Dock = DockStyle.Fill;
            tab.Controls.Add(p);
            this.tabControl1.SelectedTab = tab;
        }
    }
}