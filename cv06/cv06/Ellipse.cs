using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Ellipse : Object2D
    {
        private double a = 0;
        private double b = 0;

        public Ellipse(double a, double b)
        {
            A = a;
            B = b;
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

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
                else
                {
                    throw new Exception("(b) input value must be positiv");
                }
            }
        }

        /*********************************************************************

                                   INTERFACE FUNCTIONS

        *********************************************************************/

        public override void Draw()
        {
            // Valec (r = 1,54; v = 5,41)
            Console.WriteLine("Ellipse (a = {0}; b = {1})", A, B);
        }

        public override double SumContent()
        {
            return SumContent(A, B);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        public static double SumContent(double value1, double value2)
        {
            return (value1 * value1 * Math.PI);
        }
    }
}
