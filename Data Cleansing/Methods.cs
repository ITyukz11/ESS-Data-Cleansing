using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Cleansing
{
    internal class Methods
    {
        public void Accordion(PictureBox image, Panel panel, bool expanded)
        {
            if (expanded)
            {
                panel.BackColor = Color.Gainsboro;
               
                panel.Size = new Size(681, 33);
                image.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {

                panel.BringToFront();
                panel.BackColor = Color.PeachPuff;
                panel.Size = new Size(681, panel.PreferredSize.Height);
                image.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            image.Invalidate();
        }
    }
}
