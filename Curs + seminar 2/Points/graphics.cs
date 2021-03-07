using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class graphics
    {
        public Graphics grp;
        public Bitmap bmp;
        public PictureBox display;
        public int resX, resY;
        public Color backColor;

        public graphics(PictureBox display, Color backColor)
        {
            this.display = display;
            this.backColor = backColor;
            resX = display.Width;
            resY = display.Height;
            bmp = new Bitmap(resX, resY);
            grp = Graphics.FromImage(bmp);
            clear();
            refresh();
        }

        public void refresh()
        {
            display.Image = bmp;
        }

        public void clear()
        {
            grp.Clear(backColor);
        }
    }
}
