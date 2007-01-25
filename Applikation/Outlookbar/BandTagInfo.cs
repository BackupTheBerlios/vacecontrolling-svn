using System;
using System.Collections.Generic;
using System.Text;

namespace VACE_Controlling.Outlookbar
{
    internal class BandTagInfo
    {
        public OutlookBar outlookBar;
        public int index;

        public BandTagInfo(OutlookBar ob, int index)
        {
            outlookBar = ob;
            this.index = index;
        }
    }
}
