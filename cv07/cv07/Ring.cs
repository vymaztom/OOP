using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    class Ring : Object2D
    {
        public Ring(double r) 
        {
            this.ObjectArea = Math.PI * r * r;
        }

        public override string ToString() 
        {
            return String.Format("Ring: S = {0:0.00}", ObjectArea);
        }
    }
}
