using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Cylinder : Object3D
    {
        private double r = 0;
        private double v = 0;

        public Cylinder(double r, double v)
        {
            R = r;
            V = v;
        }

        /*********************************************************************

                                   SET & GET PROP

        *********************************************************************/

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value >= 0)
                {
                    r = value;
                }
                else
                {
                    throw new Exception("(r) input value must be positiv");
                }
            }
        }

        public double V
        {
            get
            {
                return v;
            }
            set
            {
                if (value >= 0)
                {
                    v = value;
                }
                else
                {
                    throw new Exception("(v) input value must be positiv");
                }
            }
        }

        /*********************************************************************

                                   INTERFACE FUNCTIONS

        *********************************************************************/

        public override void Draw()
        {
            // Valec (r = 1,54; v = 5,41)
            Console.WriteLine("Cylinder (r = {0}; v = {1})", R, V);
        }

        public override double SumContent()
        {
            return SumContent(R, V);
        }

        public override double SumCapacity()
        {
            return SumCapacity(R, V);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        public static double SumContent(double value1, double value2)
        {
            return ((2*Math.PI*value1*value1) + (2 * Math.PI * value1 * value2));
        }

        public static double SumCapacity(double value1, double value2)
        {
            return (value2 * Math.PI * value1 * value1);
        }
    }
}
