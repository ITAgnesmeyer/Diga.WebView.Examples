using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Diga.WebView.Examples
{
    public partial class NavTextBox : UserControl,INotifyPropertyChanged
    {
        private string _Text;
        public  event EventHandler SourceTextChanged;
        public new string Text
        {
            get
            {
                var textBox = this.txtUrl;
                if (textBox != null && this._Text != textBox.Text)
                {
                    this._Text = this.txtUrl.Text;
                }
                return this._Text; 

            }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                
                if (this._Text == value) return;

                this._Text = value;
                OnPropertyChanged();
                // ReSharper disable once RedundantCheckBeforeAssignment
                if (this._Text != this.txtUrl.Text)
                {
                    this.txtUrl.Text = this._Text;
                }

                
            } 
        }

        public NavTextBox()
        {
            InitializeComponent();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                string txt = this.txtUrl.Text;
                if (txt.Length > 0)
                {
                    if (txt.StartsWith("http://") || txt.StartsWith("https://") || txt.StartsWith("file://") ||
                        txt.StartsWith("ftp://"))
                    {

                    }
                    else
                    {
                        txt = "https://" + txt;
                    }
                    try
                    {
                        Uri url = new Uri(txt);
                        this.Text  = url.AbsoluteUri;
                        OnSourceTextChanged();
                    }
                    catch (Exception )
                    {
                        
                        //throw;
                    }

                }

                e.Handled = true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnSourceTextChanged()
        {
            SourceTextChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
