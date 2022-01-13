using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diga.WebView.Examples
{


    public partial class CloseableTabControl : TabControl
    {

        public Image CloseImage { get; set; }

        public CloseableTabControl() : base()
        {
            this.CloseImage = Properties.Resources._8kuxe;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            try
            {
                var tabRect = this.GetRectFromTabIndex(e.Index);
                Rectangle imageRect = GetImageRect(this.CloseImage, tabRect);
                var sf = new StringFormat(StringFormat.GenericDefault);
                e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, Brushes.Black, tabRect, sf);
                e.Graphics.DrawImage(this.CloseImage, imageRect.Location);

            }
            catch (Exception)
            {
                // ignored
            }
        }

        private Rectangle GetRectFromTabIndex(int index)
        {
            var tabRect = this.GetTabRect(index);
            tabRect.Inflate(-2, -2);
            return tabRect;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            bool wasHandled = false;
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                var tabRect = this.GetRectFromTabIndex(i);
                var imageRect = GetImageRect(this.CloseImage, tabRect);
                if (imageRect.Contains(e.Location))
                {
                    wasHandled = true;
                    
                    this.TabPages[i].Controls[0].Dispose();
                    this.TabPages.RemoveAt(i);
                    break;
                }
            }

            if (!wasHandled)
                base.OnMouseClick(e);
        }



        private static Rectangle GetImageRect(Image closeImage, Rectangle tabRect)
        {

            var imageRect = new Rectangle(tabRect.Right - closeImage.Width,
                tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                closeImage.Width,
                closeImage.Height);

            return imageRect;
        }
    }
}