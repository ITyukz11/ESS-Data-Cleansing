using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Cleansing
{
    internal class FormDesign
    {
        public void InitializePanelWithBorderRadiusAndShadow(Panel panel, int borderRadius, int shadowSize)
        {
           // panel.Size = new Size(200, 100);
           // panel.BackColor = Color.LightBlue;

            // Set the region to make the panel have rounded corners
            SetRoundedRegion(panel, borderRadius);

            // Draw shadow around the panel
            DrawPanelShadow(panel, shadowSize);
        }

        public void InitializeProgressBarWithBorderRadius(ProgressBar progressBar)
        {
           // progressBar.Size = new Size(200, 20);

            // Set the region to make the progress bar have rounded corners
            
            SetRoundedRegion(progressBar, 10); // 10 is the radius of the corners
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90);


                control.Region = new Region(path);
            }
        }

        private void DrawPanelShadow(Panel panel, int shadowSize)
        {
            panel.Paint += (sender, e) =>
            {
                using (Graphics g = e.Graphics)
                {
                    Rectangle shadowRect = new Rectangle(
                        panel.Left + shadowSize,
                        panel.Top + shadowSize,
                        panel.Width,
                        panel.Height);

                    int blurSize = 5; // Adjust the blur size as needed

                    for (int i = 0; i < blurSize; i++)
                    {
                        int alpha = 50 + i * (205 / blurSize); // Ensure alpha stays within valid range
                        Color shadowColor = Color.FromArgb(alpha, Color.Black);
                        using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                        {
                            g.FillRectangle(shadowBrush, shadowRect);
                        }
                    }
                }
            };
        }
    }
}
