using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace VACE_Controlling.Outlookbar
{
    public abstract class ContentPanel : Panel
    {
        public OutlookBar outlookBar;

        public ContentPanel()
        {
            // initial state
            Visible = true;
        }
    }
}
