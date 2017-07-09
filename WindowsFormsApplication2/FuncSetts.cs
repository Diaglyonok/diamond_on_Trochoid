using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class FuncSetts
    {
        public float a_rad, b_dist, step;

        public FuncSetts(float a_rad, float b_dist, float step)
        {
            this.a_rad = a_rad;
            this.b_dist = b_dist;
            this.step = step;
        }

        public PointF getPoint(float angle, PointF center)
        { 
            float x = (float)(a_rad*angle - b_dist * Math.Sin(angle));
            float y = (float)(-(a_rad - b_dist * Math.Cos(angle)));

            return new PointF(x, y+center.Y);
        }

        
        
    }
}
