using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Diga.WebView2.WinForms.Scripting;
using Diga.WebView2.WinForms.Scripting.DOM;
using Diga.WebView2.Wrapper;

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

        private string DecodeDOMString(string html)
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
            DOMElement button = await doc.getElementByIdAsync("bnTest");
            if (button == null)
            {
                await this.webViewCode.GetDOMWindow().alertAsync("Could not find bnTest");
                return;
            }

            DOMEventListenerScript script = new DOMEventListenerScript(button,"click");
            await button.addEventListenerAsync("click",script,false);
            button.DomEvent += async (_,ev) =>
            {
                if (ev.EventName == "click")
                {
                    string value =await this.webViewCode.ExecuteScriptAsync("return GetCode();");
                    value = DecodeDOMString(value);
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
                        
                        await this.webViewCode.GetDOMWindow().alertAsync(exception.ErrorObject.ToString());
                    }
                    

                }
            }
        }

        private string GetDocumentContent()
        {
            string value =this.webViewCode.ExecuteScriptSync("return GetCode();");
            value = DecodeDOMString(value);
            return value;

        }
        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string value =await this.webViewCode.ExecuteScriptAsync("return GetCode();");
            value = DecodeDOMString(value);
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

        private void ShowContent(bool encoded = false)
        {
            string content = GetDocumentContent();
            if (string.IsNullOrEmpty(content)) return;
            if (encoded)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(content);
                string base64 = Convert.ToBase64String(bytes);
                content = "data:text/html;charset=utf-8;base64," + base64; 

            }
            using (var f = new Form())
            {
                f.Text = "Content: Encoded=" + encoded.ToString();
                f.Width = 800;
                f.Height = 600;
                f.StartPosition = FormStartPosition.CenterParent;
                TextBox textBox = new TextBox();
                textBox.Multiline = true;
                textBox.ScrollBars = ScrollBars.Both;
                
                textBox.Font = new Font("Courier New", 12);
                textBox.ForeColor = Color.DarkBlue;
                textBox.Dock = DockStyle.Fill;
                textBox.Text = content;
                f.Controls.Add(textBox);

                f.ShowDialog(this);
            }
        }

        private void webViewPreView_PermissionRequested(object sender, Diga.WebView2.Wrapper.EventArguments.PermissionRequestedEventArgs e)
        {
            MessageBox.Show("Permission request");
        }

        private void encodedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent(true);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowContent();
        }

        private void vSCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVSCode vsCode = new frmVSCode();
            vsCode.Show();
        }
    }
}
