using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class PersonalCar:Car
    {
        private int maxPerson;
        private List<String> person;

        public PersonalCar(FUEL kindOfFuel, double sizeOfTank, int maxPerson)
            : base(kindOfFuel, sizeOfTank)
        {
            person = new List<string>();
            MaxPerson = maxPerson;
        }

        private int MaxPerson
        {
            get
            {
                return maxPerson;
            }
            set
            {
                if (value > 0)
                {
                    maxPerson = value;
                }
                else
                {
                    throw new Exception("maxPerson must be bigger then 0");
                }
            }
        }

        private int SumPerson
        {
            get
            {
                return person.Count;
            }
            set
            {
                throw new Exception("Invalid operation: ADD value into SumPerson");
            }
            
        }

        public void AddPerson(String name)
        {
            if (SumPerson < MaxPerson)
            {
                person.Add(name);
            }
            else
            {
                throw new Exception("SumPerson over MaxPerson");
            }
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder("");
            buffer.AppendFormat("Fuel:\t{0}\t{1}/{2} " + Environment.NewLine, Fuel, FullOfTank, SizeOfTank);
            buffer.AppendFormat("Person:\t\t{0}/{1}\t", SumPerson, MaxPerson);
            foreach (String item in person)
            {
                buffer.AppendFormat("({0})", item);
            }
            return buffer.ToString();
        }
    }
}
