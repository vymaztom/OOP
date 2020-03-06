using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    abstract class Car
    {
        // public variables
        public enum FUEL {Benzine, Oil};
        public CarRadio Radio;

        // private variables
        protected FUEL fuel;
        protected double sizeOfTank;
        protected double fullOfTank;

        public Car(FUEL kindOfFuel, double valueSizeOfTank)
        {
            Radio = new CarRadio();
            fuel = kindOfFuel;
            SizeOfTank = valueSizeOfTank;
            FullOfTank = 0.0;
        }

        protected double SizeOfTank
        {
            get
            {
                return sizeOfTank;
            }
            set
            {
                if (value > 0)
                {
                    sizeOfTank = value;
                }
                else
                {
                    throw new Exception("SizeOfTank must be bigger then 0");
                }
            }
        }

        protected String Fuel
        {
            get
            {
                String ret = "";
                if (fuel == FUEL.Benzine)
                {
                    ret = "Benzine";
                }
                else if (fuel == FUEL.Oil)
                {
                    ret = "Oil";
                }
                return ret;
            }
            set
            {
                throw new Exception("Not allowed to set FUEL");
            }
        }

        protected double FullOfTank
        {
            get
            {
                return fullOfTank;
            }
            set
            {
                if ((value >= 0.0) && (value <= SizeOfTank))
                {
                    fullOfTank = value;
                }
                else
                {
                    throw new Exception("FullOTank is not in 0.0 to SizeOfTank");
                }
            }
        }

        public void AddFuel(FUEL kindOfFuel, double inputValue)
        {
            if (fuel == kindOfFuel)
            {
                if ((inputValue+fullOfTank)<=sizeOfTank)
                {
                    fullOfTank += inputValue;
                }
                else
                {
                    throw new Exception("Tank will be full, use smaller inputValue");
                }
            }
            else
            {
                throw new Exception("Bad Fuel in function AddFuel");
            }

        }
    }
}
