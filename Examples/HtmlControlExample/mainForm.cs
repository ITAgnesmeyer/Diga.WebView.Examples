using Diga.Core.Threading;

namespace HtmlControlExample
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        private MyControl? _MyControl;

        private void DocumentLoading()
        {
            this._MyControl = new MyControl(this.webViewMain);
            this._MyControl.Click += OnButtonClick;
        }

        private void OnButtonClick(object? sender, EventArgs e)
        {
            string email = this._MyControl.GetEmail();
            string password = this._MyControl.GetPassword();
            bool isChecked = this._MyControl.GetIsChecked();
            string message =
                $"Email:{email}{Environment.NewLine}Password:{password}{Environment.NewLine}IsChecked:{isChecked}";
            MessageBox.Show(this, message, "Info", MessageBoxButtons.OK);
        }

        private void webViewMain_DocumentLoading(object sender, EventArgs e)
        {
            DocumentLoading();
        }
    }
}