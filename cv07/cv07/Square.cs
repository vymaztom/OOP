using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Square : Object2D
    {
        public Square(double a)
        {
            this.ObjectArea = a * a;
        }

        public override string ToString()
        {
            return String.Format("Square: S = {0:0.00}", ObjectArea);
        }
    }
}
