using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Triangle : Object2D
    {
        public Triangle(double a, double va)
        {
            this.ObjectArea = a * va / 2;
        }

        public override string ToString()
        {
            return String.Format("Triangle: S = {0:0.00}", ObjectArea);
        }
    }
}
