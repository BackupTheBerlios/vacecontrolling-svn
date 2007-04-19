using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VACE_Controlling.Outlookbar
{
    internal class BandButton : Button
    {
        private BandTagInfo bti;

        public BandButton(string caption, BandTagInfo bti)
        {
            
            Text = caption;
            this.FlatStyle = FlatStyle.Popup;
            this.FlatAppearance.BorderSize = 0;

            Visible = true;
            this.bti = bti;
            Click += new EventHandler(SelectBand);
        }

        private void SelectBand(object sender, EventArgs e)
        {
            bti.outlookBar.SelectBand(bti.index);
        }
    }
}
