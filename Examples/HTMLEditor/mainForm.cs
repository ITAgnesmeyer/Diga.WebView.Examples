using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diga.WebView2.WinForms.Scripting.DOM;

namespace HTMLEditor
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

        private void webViewCode_WebViewCreated(object sender, EventArgs e)
        {
            string editHTMLPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            editHTMLPath = Path.Combine(editHTMLPath, "simple.html");
            Uri uri = new Uri(editHTMLPath);
            this.webViewCode.Navigate(uri.AbsolutePath);
        }

        private string CleanupDOMString(string html)
        {
            if (html.StartsWith("\""))
                html = html.Substring(1);
            if (html.EndsWith("\""))
            {
                html = html.Substring(0, html.Length - 1);
            }

            html = System.Text.RegularExpressions.Regex.Unescape(html);
            //string enc = html= System.Text.RegularExpressions.Regex.Escape(html);
            html = html.Replace("\n", Environment.NewLine);
            return html;
        }
        private async void webViewCode_NavigationCompleted(object sender, Diga.WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs e)
        {
            DOMDocument doc = this.webViewCode.GetDOMDocument();
            DOMElement button = await doc.getElementById("bnTest");
            if (button == null)
            {
                await this.webViewCode.GetDOMWindow().alert("Could not find bnTest");
                return;
            }

            DOMEventListenerScript script = new DOMEventListenerScript(button);
            await button.addEventListener("click", script, false);
            button.DomEvent += async (eo,ev) =>
            {
                if (ev.EventName == "click")
                {
                    string value =await this.webViewCode.ExecuteScriptAsync("return editor.getValue();");
                    value = CleanupDOMString(value);
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.webViewPreView.NavigateToString(value);
                    }
                }
            };

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
