using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class TestComplex
    {
        public static void Test(Complex trueValue, Complex testValue, String nameOfTest) {
            if (trueValue == testValue)
            {
                Console.Write("{0}",nameOfTest);
                for (int i = nameOfTest.Length; i < 50 ; i++) {
                    Console.Write(".");
                }
                Console.Write("OK\n");

            }
            else {
                Console.Write("ERR: trueValue: {0} != inputValue: {1}\n",trueValue,testValue);
            }
        }
    }
}
