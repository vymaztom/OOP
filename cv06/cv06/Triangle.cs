using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Triangle : Object2D
    {
        private double a = 0;
        private double va = 0;

        public Triangle(double a, double va)
        {
            A = a;
            Va = va;
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

        public double Va
        {
            get
            {
                return va;
            }
            set
            {
                if (value >= 0)
                {
                    va = value;
                }
                else
                {
                    throw new Exception("(va) input value must be positiv");
                }
            }
        }

        /*********************************************************************

                                   INTERFACE FUNCTIONS

        *********************************************************************/

        public override void Draw()
        {
            // Valec (r = 1,54; v = 5,41)
            Console.WriteLine("Triangle (a = {0}; va = {1})", A, Va);
        }

        public override double SumContent()
        {
            return SumContent(A, Va);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        public static double SumContent(double value1, double value2)
        {
            return (value1 * value1 / 2);
        }
    }
}
