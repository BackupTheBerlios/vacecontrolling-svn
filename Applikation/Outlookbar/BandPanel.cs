using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VACE_Controlling.Outlookbar
{
    internal class BandPanel : Panel
    {
        public BandPanel(string caption, ContentPanel content, BandTagInfo bti)
        {
            BandButton bandButton = new BandButton(caption, bti);
            Controls.Add(bandButton);
            Controls.Add(content);
            this.BorderStyle = BorderStyle.None;
        }
    }
}
