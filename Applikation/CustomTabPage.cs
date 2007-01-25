using System;
using System.Drawing;
using System.Windows.Forms;

namespace VACE_Controlling
{
	/// <summary>
	/// Summary description for UserTabPage.
	/// </summary>
	public class CustomTabPage : UserControl
    {
		public CustomTabPage()
		{
			this.SuspendLayout();
			InitializeComponent();
            this.ResumeLayout();
		}
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // MitarbeiterTab
            // 
            this.Name = "MitarbeiterTab";
            this.Size = new System.Drawing.Size(674, 421);
            this.ResumeLayout(false);

		}
	}
}
