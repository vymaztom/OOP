using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Block : Object3D
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;

        public Block(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
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

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value >= 0)
                {
                    c = value;
                }
                else
                {
                    throw new Exception("(c) input value must be positiv");
                }
            }
        }

        /*********************************************************************

                                   INTERFACE FUNCTIONS

        *********************************************************************/

        public override void Draw()
        {
            // Valec (r = 1,54; v = 5,41)
            Console.WriteLine("Block (a = {0}; b = {1}; c = {2})", A, B, C);
        }

        public override double SumContent()
        {
            return SumContent(A, B, C);
        }

        public override double SumCapacity()
        {
            return SumCapacity(A, B, C);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        public static double SumContent(double value1, double value2, double value3)
        {
            return (2 * ((value1 * value2) + (value1 * value3) + (value2 * value3)));
        }

        public static double SumCapacity(double value1, double value2, double value3)
        {
            return (value1 * value2 * value3);
        }
    }
}
