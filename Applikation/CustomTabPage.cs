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
        private CheckBox checkBox1;
    
		public CustomTabPage()
		{
			this.SuspendLayout();
			InitializeComponent();
            this.ResumeLayout();
		}
		private void InitializeComponent()
		{
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CustomTabPage
            // 
            this.Controls.Add(this.checkBox1);
            this.Name = "CustomTabPage";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
