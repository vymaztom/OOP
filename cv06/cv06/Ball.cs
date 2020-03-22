using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Ball : Object3D
    {
        private double r = 0;

        public Ball(double r)
        {
            R = r;
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

        /*********************************************************************

                                   INTERFACE FUNCTIONS

        *********************************************************************/

        public override void Draw()
        {
            // Valec (r = 1,54; v = 5,41)
            Console.WriteLine("Ball (r = {0})", R);
        }

        public override double SumContent()
        {
            return SumContent(R);
        }

        public override double SumCapacity()
        {
            return SumCapacity(R);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        public static double SumContent(double value)
        {
            return (4 * Math.PI * value * value);
        }

        public static double SumCapacity(double value)
        {
            return (3 / 4 * Math.PI * value * value * value);
        }
    }
}
