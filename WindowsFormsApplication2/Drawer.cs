using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Drawer
    {
        public PictureBox pictureHolder;
        public int height, width;
        public FuncSetts funcSetts;
        public int numOfTimes;
        public PointF center;
        public Pen p_func;
        public Pen p_diam;
        public Pen p_coord;
        public Graphics g;

        public Drawer(PictureBox pictureHolder, int height, int width, FuncSetts funcSetts, int numOfTimes, Color diamColor)
        {
            this.pictureHolder = pictureHolder;
            this.height = height;
            this.width = width;
            this.funcSetts = funcSetts;
            this.numOfTimes = numOfTimes;
            center = new PointF(pictureHolder.Width / 2, pictureHolder.Height / 2);
            p_func = new Pen(Color.Red);
            p_diam = new Pen(diamColor);
            p_coord = new Pen(Color.Black);
            g = pictureHolder.CreateGraphics();
        }

        public void drawDiamond(PointF center, Pen p, Graphics g)
        {
            PointF[] ps = new PointF[4];
            ps[0] = new PointF(center.X, center.Y - height / 2);
            ps[1] = new PointF(center.X + width / 2, center.Y);
            ps[2] = new PointF(center.X, center.Y + height / 2);
            ps[3] = new PointF(center.X - width / 2, center.Y);

            g.DrawPolygon(p, ps);
        }
        

        public List<PointF> DrawFuncByStep()
        {
            List<PointF> points = new List<PointF>();


            for (float i = 0; i < 6.28*numOfTimes; i += funcSetts.step)
            {

                PointF curr = funcSetts.getPoint(i, center);
                points.Add(curr);
                
                g.Clear(Color.White);

                drawCoordinates(g, p_coord);
                try
                {
                    g.DrawLines(p_func, points.ToArray());
                }
                catch { Console.Out.Write("ERROR"); }

                drawDiamond(curr, p_diam, g);
                Thread.Sleep(25);
            }

            return points;
        }

        public void drawCoordinates(Graphics g, Pen p)
        {
            g.DrawLine(p, new Point(pictureHolder.Width / 2, 0), new Point(pictureHolder.Width / 2, pictureHolder.Height));
            g.DrawLine(p, new Point(0, pictureHolder.Height / 2), new Point(pictureHolder.Width, pictureHolder.Height / 2));
        }

    }
}
