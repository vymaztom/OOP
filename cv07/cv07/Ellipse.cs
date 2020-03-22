using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Ellipse : Object2D
    {
        public Ellipse(double a, double b)
        {
            this.ObjectArea = Math.PI * a * b;
        }

        public override string ToString()
        {
            return String.Format("Ellipse: S = {0:0.00}", ObjectArea);
        }
    }
}
