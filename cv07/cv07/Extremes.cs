using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    static class Extremes
    {
        public static T Max<T>(T[] inputArray) where T : IComparable
        {
            if (inputArray.Length > 0)
            {
                T one = inputArray[0];
                foreach (T item in inputArray)
                {
                    if (one.CompareTo(item) < 0) 
                    {
                        one = item;
                    }
                }
                return one;
            }
            else
            {
                throw new Exception("empty array");
            }
            
        }

        public static T Min<T>(T[] inputArray) where T : IComparable
        {
            if (inputArray.Length > 0)
            {
                T one = inputArray[0];
                foreach (T item in inputArray)
                {
                    if (one.CompareTo(item) > 0)
                    {
                        one = item;
                    }
                }
                return one;
            }
            else
            {
                throw new Exception("empty array");
            }

        }
    }
}
