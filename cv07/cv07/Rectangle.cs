using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Rectangle : Object2D
    {
        public Rectangle(double a, double b)
        {
            this.ObjectArea = a * b;
        }

        public override string ToString()
        {
            return String.Format("Rectangle: S = {0:0.00}", ObjectArea);
        }
    }
}
