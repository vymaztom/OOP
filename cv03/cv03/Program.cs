using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix_a = new double[,]{{1,2,3},{4,5,6}};
            double[,] matrix_b = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            double[,] matrix_c = new double[,] { { 1, 2}, {3, 4},{ 5,6 }};
            double[,] matrix_det = new double[,] { { 4, 2,-8 }, { -3, 4, 10 }, { -30, 5, 0 } };
            matrix a = new matrix(matrix_a);
            matrix b = new matrix(matrix_b);
            matrix c = new matrix(matrix_c);
            matrix det = new matrix(matrix_det);
            matrix ret = a - b;
            matrix minus = -a;
            try
            {
                my_line_one("TEST A + B", a + b);
                my_line_one("TEST A - B", ret);
                my_line_one("TEST A * B", a * c);
            }
            catch {
                Console.Write("ERR: ivalid dimensions of matrixs");
            }

            my_line_one("TEST -A", minus);
            my_line_one("TEST jednotkova matice", matrix.BasicMatrix(5));
            try {
                Console.Write("Determinat det MATICE: {0,10:F5}" + Environment.NewLine, det.det());
            } catch {
                Console.Write("ERR: not squer matrix");
            }
            

            
            Console.ReadLine();
        }
        
        public static void my_line_one(String text, matrix a)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
            Console.Write("\t\t" + text);
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
            Console.Write(a.ToString());
            Console.Write(Environment.NewLine);
        }
    }
}
