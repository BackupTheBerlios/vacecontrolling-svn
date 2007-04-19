using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace VACE_Controlling.Outlookbar
{
    public class ContentPanel : Panel
    {
        public OutlookBar outlookBar;

        public ContentPanel()
        {
            // initial state
            Visible = true;
            this.BorderStyle = BorderStyle.None;
        }
    }
}
