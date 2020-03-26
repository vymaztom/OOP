using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv08
{
    class YearTemperature
    {
        private int year = 0;
        private List<double> data;
        
        public YearTemperature(int year, List<double> data) 
        {
            this.year = year;
            this.data = data;
        }

        public YearTemperature(int year)
        {
            this.year = year;
            this.data = new List<double> { };
        }

        public List<double> MonthTemperature
        {
            get 
            {
                return data;
            }
            set 
            {
                if (value.Count != 12)
                {
                    throw new Exception("Invalid input");
                }
                else
                {
                    data = value;
                }
            }
        }

        public double MaxTemperatre 
        {
            get 
            {
                return data.Max();
            }
            
        }

        public double MinTemperatre
        {
            get
            {
                return data.Min();
            }
            
        }

        public double AverageTemperatre
        {
            get
            {
                double sum = 0;
                foreach (double item in data)
                {
                    sum += item;
                }
                if (data.Count > 0)
                {
                    return sum / data.Count;
                }
                else
                {
                    throw new Exception("None data into YearTemperature");
                }
            }

        }

        public void Calibration(double value)
        {
            for (int i = 0; i < data.Count; i++)
            {
                data[i] += value;
            }
        }

        public List<double> Data
        {
            get
            {
                return data;
            }
        }
    }
}
