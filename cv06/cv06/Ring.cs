using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    class Ring : Object2D
    {
        private double r = 0;

        public Ring(double r)
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
            Console.WriteLine("Ring (r = {0})",R);
        }

        public override double SumContent()
        {
            return SumContent(R);
        }

        /*********************************************************************
          
                                    STATIC FUNCTIONS

        *********************************************************************/

        public static double SumContent(double value)
        {
            return (Math.PI*value*value);
        }

    }
}
