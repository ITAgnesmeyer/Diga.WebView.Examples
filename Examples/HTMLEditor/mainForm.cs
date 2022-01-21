using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Diga.WebView2.WinForms.Scripting;
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
            if (editHTMLPath != null)
            {
                editHTMLPath = Path.Combine(editHTMLPath, "simple.html");
                Uri uri = new Uri(editHTMLPath);
                this.webViewCode.Navigate(uri.AbsolutePath);
            }
        }

        private string DocodeDOMString(string html)
        {
            if (html.StartsWith("\""))
                html = html.Substring(1);
            if (html.EndsWith("\""))
            {
                html = html.Substring(0, html.Length - 1);
            }



            html = System.Text.RegularExpressions.Regex.Unescape(html);
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
            button.DomEvent += async (_,ev) =>
            {
                if (ev.EventName == "click")
                {
                    string value =await this.webViewCode.ExecuteScriptAsync("return GetCode();");
                    value = DocodeDOMString(value);
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

        private async void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"*.html|*.html";
            DialogResult result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string str = await File.ReadAllTextAsync(ofd.FileName,Encoding.UTF8);
                if (!string.IsNullOrEmpty(str))
                {
                    //str = "<h3>testxyz</h3>";
                    //str= EncodeDOMString(str);
                    byte[] bytes = Encoding.UTF8.GetBytes(str);
                    string base64 = Convert.ToBase64String(bytes);


                    string script = $"SetCode(\"{base64}\");";

                    //script = "TestSetCode();";
                    try
                    {
                        await this.webViewCode.ExecuteScriptAsync(script);
                    }
                    catch (ScriptException exception)
                    {
                        
                        await this.webViewCode.GetDOMWindow().alert(exception.ErrorObject.ToString());
                    }
                    

                }
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string value =await this.webViewCode.ExecuteScriptAsync("return GetCode();");
            value = DocodeDOMString(value);
            if (string.IsNullOrEmpty(value)) return;
            


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"*.html|*.html";
            DialogResult result = saveFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                {
                    File.Delete(saveFileDialog.FileName);
                }
                await File.WriteAllTextAsync(saveFileDialog.FileName, value, Encoding.UTF8);
            }





        }
    }
}
