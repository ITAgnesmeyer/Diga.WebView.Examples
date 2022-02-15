using Diga.Core.Threading;

namespace HtmlControlExample
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private MyControl _MyControl;
        private void webViewMain_DOMContentLoaded(object sender, Diga.WebView2.Wrapper.EventArguments.DOMContentLoadedEventArgs e)
        {
            UIDispatcher.UIThread.Post(() =>
            {
                this._MyControl = new MyControl(this.webViewMain);
                this._MyControl.Click += OnButtonClick;
            });
            

        }

        private void OnButtonClick(object? sender, EventArgs e)
        {
            string email = this._MyControl.GetEmail();
            string passowrd = this._MyControl.GetPassword();
            bool isCheckd = this._MyControl.GetIsChecked();
            string message =
                $"Email:{email}{Environment.NewLine}Password:{passowrd}{Environment.NewLine}IsChecked:{isCheckd}";
            MessageBox.Show(this, message, "Info", MessageBoxButtons.OK);
        }
    }
}