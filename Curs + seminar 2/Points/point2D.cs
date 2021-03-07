using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class point2D
    {
        public static Random rnd = new Random();
        public float X, Y;
        public Color fillColor;
        public Color drawColor;

        public point2D(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public point2D()
        {
            
        }

        public point2D(graphics T)
        {
            X = rnd.Next(T.resX);
            Y = rnd.Next(T.resY);
            fillColor = Color.Red;
            drawColor = Color.Black;
        }

        public void draw(graphics T)
        {
            int radius = 20;
            T.grp.FillEllipse(new SolidBrush(fillColor), X - radius/2, Y - radius/2, radius, radius);
            T.grp.DrawEllipse(new Pen(drawColor), X - radius / 2, Y - radius / 2, radius, radius);

        }
    }
}
