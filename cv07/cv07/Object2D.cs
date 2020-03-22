using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    abstract class Object2D : I2D, IComparable
    {
        protected double objectArea = 0;

        public double Area() {
            return ObjectArea;
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;

            Object2D one = (Object2D)obj;
            if (one != null)
            {
                return this.ObjectArea.CompareTo(one.ObjectArea);
            }
            else
            {
                throw new ArgumentException("Object is not a Object2D");
            }
        }

        public double ObjectArea {
            get
            {
                return objectArea;
            }
            set
            {
                if (value >= 0)
                {
                    objectArea = value;
                }
                else
                {
                    throw new Exception("Area must be positive value");
                }
            }
        }
    }
}
