using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Pyramid : Object3D
    {
        private double a = 0;
        private double v = 0;
        private int n = 0;

        public Pyramid(double a, double v, int n)
        {
            A = a;
            V = v;
            N = n;
        }

        /*********************************************************************

                                   SET & GET PROP

        *********************************************************************/

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
                else
                {
                    throw new Exception("(a) input value must be positiv");
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

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value >= 0)
                {
                    n = value;
                }
                else
                {
                    throw new Exception("(n) input value must be positiv");
                }
            }
        }

        /*********************************************************************

                                   INTERFACE FUNCTIONS

        *********************************************************************/

        public override void Draw()
        {
            // Valec (r = 1,54; v = 5,41)
            Console.WriteLine("Pyramid (a = {0}; v = {1}; n = {2})", A, V, N);
        }

        public override double SumContent()
        {
            return SumContent(A, V, N);
        }

        public override double SumCapacity()
        {
            return SumCapacity(A, V, N);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        private static double SumContentBase(double a, int n)
        {
            return ((n*a*a)/(4*Math.Tan(Math.PI/n)));
        }

        public static double SumContent(double value1, double value2, int value3)
        {
            double x = (value1/2) / (Math.Tan(Math.PI/value3));
            double y = Math.Sqrt((value2*value2) + (x*x));

            return (SumContentBase(value1, value3) + (value3/2*x*value1));
        }

        public static double SumCapacity(double value1, double value2, int value3)
        {
            return (1/3 * SumContentBase(value1, value3) * value2);
        }
    }
}
