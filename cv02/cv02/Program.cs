using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02{


    class Program{

        static void Main(string[] args){
            //Complex a = new Complex(-5 ,0);
            Complex a = new Complex(5, -2);
            Complex b = new Complex(-1, -3);
            TestComplex.Test(new Complex(4, -5), a + b, "cSUM(a+b)");
            TestComplex.Test(new Complex(6, 1), a - b, "cDIFF(a-b)");
            TestComplex.Test(new Complex(-11, -13), a * b, "cMULT(a*b)");
            TestComplex.Test(new Complex(0.1, 1.7), a / b, "cDIVE(a/b)");
            TestComplex.Test(new Complex(-5,2), -a, "cUNI(-a)");
            for (int i = 0; i < 52; i++) {
                Console.Write("-");
            }
            Console.Write("\n");
            Console.Write("MIR of conplex a (--a) = \t{0} \n", a.mirror().ToString());
            Console.Write("MOD of conplex a (|a|) = \t{0:F5} \n",a.mod());
            Console.Write("ARG of conplex a (arg a) = \t{0:F2} rad = {1:F2}° \n", a.arg(), (a.arg()*180)/Math.PI);
            Console.ReadLine();
        }
    }
}
