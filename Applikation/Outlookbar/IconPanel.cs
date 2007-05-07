using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VACE_Controlling.Outlookbar
{
    public class IconPanel : ContentPanel
	{
		protected int iconSpacing;
		protected int margin;

		public int IconSpacing
		{
			get
			{
				return iconSpacing;
			}
		}
        public int Margin
        {
            get
            {
                return margin;
            }
        }

        public void setColor (Color c)
        {
            this.BackColor = c;
        }
		public IconPanel()
		{
			margin=10;
			iconSpacing=32+15+10;	// icon height + text height + margin
			BackColor=Color.LightBlue;
			AutoScroll=true;
            this.BorderStyle = BorderStyle.None;
		}

		public void AddIcon(string caption, EventHandler onClickEvent)
		{
			int index=Controls.Count/2;	// two entries per icon
			PanelIcon panelIcon=new PanelIcon(this, index, onClickEvent,caption);
			Controls.Add(panelIcon);

            Image image = panelIcon.Image;

			Label label=new Label();
			label.Text=caption;
			label.Visible=true;
			label.Location=new Point(0, margin+image.Size.Height+index*iconSpacing);
			label.Size=new Size(Size.Width, 15);
			label.TextAlign=ContentAlignment.TopCenter;
			label.Click+=onClickEvent;
			label.Tag=panelIcon;
			Controls.Add(label);
		}
	}
}
