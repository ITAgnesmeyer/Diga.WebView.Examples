using System;

namespace Diga.WebView.Examples
{



    public class SourceChangeEventArgs : EventArgs
    {
        public string Url { get; }

        public SourceChangeEventArgs(string url)
        {
            this.Url = url;
        }
    }
}