using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVGViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.svg|*.svg";
            DialogResult result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.webView1.Navigate(ofd.FileName);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webView1.GetDOMWindow().print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string folder = fbd.SelectedPath;
                FillListViewWithData(folder);
            }
        }

        private void FillListViewWithData(string folder)
        {
            this.listBox1.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            if (!dirInfo.Exists) return;
            var files = dirInfo.GetFiles("*.svg");
            foreach (FileInfo file in files)
            {
                int index = this.listBox1.Items.Add(file.FullName);
                

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            string file = (string)this.listBox1.SelectedItem;
            if (File.Exists(file))
            {
                this.webView1.Navigate(file);
            }
        }

        private void bnBGColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            var result = cd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.webView1.DefaultBackgroundColor = cd.Color;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double dbl = this.trackBar1.Value / 100.000;
            if (dbl == 0)
                dbl = 1;
            this.webView1.ZoomFactor = dbl;
        }
    }
}
