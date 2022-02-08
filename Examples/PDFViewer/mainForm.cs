using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFViewer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.pdf|*.pdf";
            DialogResult result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.webView1.Navigate(ofd.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView1.GetDOMWindow().print();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView1.GoForward();
        }

        private void backwradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView1.GoBack();
        }

        private void webView1_NavigationCompleted(object sender, Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                this.toolStripStatusLabel1.Text = this.webView1.Source;
            }
        }
    }
}
