using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diga.WebView.Examples
{
    public partial class BrowserPage : UserControl
    {
        public event EventHandler<SourceChangeEventArgs> SourceChange;
        public BrowserPage()
        {
            InitializeComponent();
        }

        private void bnBack_Click(object sender, EventArgs e)
        {
            this.WebView.GoBack();
        }

        private void bnForward_Click(object sender, EventArgs e)
        {
            this.WebView.GoForward();
        }

        private void bnGo_Click(object sender, EventArgs e)
        {
            this.WebView.Navigate(this.txtNavigation.Text);
        }

        private void WebView_NavigationCompleted(object sender, WebView2.Wrapper.EventArguments.NavigationCompletedEventArgs e)
        {
            this.txtNavigation.Text = this.WebView.Source;
            OnSourceChange(new SourceChangeEventArgs(this.WebView.Source));
        }

        protected virtual void OnSourceChange(SourceChangeEventArgs e)
        {
            SourceChange?.Invoke(this, e);
        }

        private void txtNavigation_SourceTextChanged(object sender, EventArgs e)
        {
            this.WebView.Navigate(this.txtNavigation.Text);
        }

        private void bnReload_Click(object sender, EventArgs e)
        {
            this.WebView.Reload();
        }
    }
}
