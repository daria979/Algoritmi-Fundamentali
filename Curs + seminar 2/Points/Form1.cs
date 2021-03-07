using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        graphics myGrp;
        List<point2D> points;


        public Form1()
        {
            InitializeComponent();

        }
            float dEuclid(point2D A, point2D B)
            {

                return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)); //distanta 
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            points = new List<point2D>();
            int n = 15;//MODIFY HERE to have more points  <-------------
            myGrp = new graphics(pictureBox1, Color.LightBlue);
            for (int i = 0; i < n; i++)
            {
                points.Add(new point2D(myGrp));
            }

            float min = dEuclid(points[0], points[1]);
            float max = dEuclid(points[0], points[1]);
            int idx1_min = 0;
            int idx2_min = 0;
            int idx1_max = 0;
            int idx2_max = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    float t = dEuclid(points[i], points[j]);
                    if (t < min)
                    {
                        min = t;
                        idx1_min = i;
                        idx2_min = j;
                    }
                    if (t > max)
                    {
                        max = t;
                        idx1_max = i;
                        idx2_max = j;
                    }
                }
            }
            


            myGrp.grp.DrawLine(Pens.Green,points[idx1_min].X,points[idx1_min].Y, points[idx2_min].X, points[idx2_min].Y);
            myGrp.grp.DrawLine(Pens.Yellow, points[idx1_max].X, points[idx1_max].Y, points[idx2_max].X, points[idx2_max].Y);


            foreach (point2D p in points)
            {
                p.draw(myGrp);
            }

            myGrp.refresh();

            
        }
    }
}
