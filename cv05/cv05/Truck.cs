using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Truck:Car
    {
        private double maxCargo;
        private Dictionary<String,double> cargo;
        
        public Truck(FUEL kindOfFuel, double sizeOfTank, double maxCargo)
            :base(kindOfFuel, sizeOfTank)
        {
            this.MaxCargo = maxCargo;
            this.cargo = new Dictionary<String, double>();
        }

        public void AddCargo(String name, double valueOfCargo)
        {
            if (valueOfCargo > 0)
            {
                if ((SumCargo + valueOfCargo) <= maxCargo)
                {
                    cargo.Add(name, valueOfCargo);
                }
                else
                {
                    throw new Exception("MaxCargo over in function Add Cargo");
                }
            }
            else
            {
                throw new Exception("Cargo must be bigger then 0");
            }

        }

        private double MaxCargo
        {
            get
            {
                return maxCargo;
            }
            set
            {
                if (value > 0)
                {
                    maxCargo = value;
                }
                else
                {
                    throw new Exception("Cargo must be bigger then 0");
                }
            }
        }

        private double SumCargo
        {
            get
            {
                double ret = 0.0;
                foreach (KeyValuePair<String, double> item in cargo)
                {
                    ret += item.Value;
                }
                return ret;
            }
            set
            {
                throw new Exception("Invalide operation: try to change SumCargo");
            }
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder("");
            buffer.AppendFormat("Fuel:\t{0}\t{1}/{2} "+ Environment.NewLine, Fuel, FullOfTank, SizeOfTank);
            buffer.AppendFormat("Cargo:\t\t{0}/{1}\t", SumCargo, MaxCargo);
            int i = 0;
            foreach (KeyValuePair<String, double> item in cargo)
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    buffer.Append(", ");
                }
                buffer.AppendFormat("{0} ({1})", item.Key, item.Value);
            }
            return buffer.ToString();
        }
    }
}
