using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace VACE_Controlling.Outlookbar
{
    public class PanelIcon : PictureBox
    {
        public int index;
        public IconPanel iconPanel;
        public Image tmp;
        public String name;

        private Color bckgColor;
        private bool mouseEnter;

        public int Index
        {
            get
            {
                return index;
            }
        }
        public PanelIcon(IconPanel parent, int index, EventHandler onClickEvent,String name)
        {
            this.index = index;
            this.iconPanel = parent;
            this.Image = Image.FromFile("images/normal/" + name+".png");

            Visible = true;
            Location = new Point(iconPanel.outlookBar.Size.Width / 2 - Image.Size.Width / 2,
                            iconPanel.Margin + index * iconPanel.IconSpacing);
            this.name = name;
            Size = Image.Size;
            Click += onClickEvent;
            Tag = this;

            MouseEnter += new EventHandler(OnMouseEnter);
            MouseLeave += new EventHandler(OnMouseLeave);
            MouseMove += new MouseEventHandler(OnMouseMove);

            bckgColor = iconPanel.BackColor;
            mouseEnter = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs args)
        {
            if ((args.X < Size.Width - 2) &&
                (args.Y < Size.Width - 2) &&
                (!mouseEnter))
            {
               
                //BorderStyle = BorderStyle.FixedSingle;
                this.tmp = this.Image;
                this.Image = Image.FromFile("images/hover/" + name + "_hover.png");
                //Location = Location - new Size(1, 1);
                mouseEnter = true;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (mouseEnter)
            {
                this.Image = Image.FromFile("images/normal/" + name + ".png");
                BorderStyle = BorderStyle.None;
               // Location = Location + new Size(1, 1);
                mouseEnter = false;
            }
        }
    }
}
