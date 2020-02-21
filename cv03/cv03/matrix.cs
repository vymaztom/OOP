using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class matrix
    {
        private double[,] data;
        private int size_x;
        private int size_y;

        public matrix(double[,] input)
        {
            this.data = input;
            this.size_x = input.GetLength(0);
            this.size_y = input.GetLength(1);
        }

        public static matrix operator +(matrix a, matrix b)
        {
            matrix ret = new matrix(a.data);
            if ((a.size_x == b.size_x) && (a.size_y == b.size_y))
            {
                for (int i = 0; i < a.size_x; i++) {
                    for (int j = 0; j < a.size_y; j++) {
                        ret.data[i, j] = a.data[i, j] + b.data[i, j];
                    }
                }              
            }
            else {
                throw new Exception("Different dimension of matrixs (+)");
            }
            return ret;
        }

        public static matrix operator -(matrix a, matrix b)
        {
            double[,] ret = new double[a.size_x, b.size_y];
            if ((a.size_x == b.size_x) && (a.size_y == b.size_y))
            {
                for (int i = 0; i < a.size_x; i++)
                {
                    for (int j = 0; j < a.size_y; j++)
                    {
                        ret[i, j] = a.data[i, j] - b.data[i, j];
                    }
                }
            }
            else
            {
                throw new Exception("Different dimension of matrixs (-)");
            }
            return new matrix(ret);
        }
        public static matrix operator *(matrix a, matrix b)
        {
            double[,] ret = new double[a.size_x, b.size_y];
            if ((a.size_y == b.size_x))
            {
                for (int i = 0; i < a.size_x; i++)
                { 
                    for (int j = 0; j < b.size_y; j++)
                    {
                        double sum = 0;
                        for (int k = 0; k < a.size_y; k++) {
                            sum += a.data[i, k] * b.data[k, j];

                        }
                        ret[i, j] = sum;
                    }
                }
            }
            else
            {
                throw new Exception("Diffrent dimensins of matrix(*)");
            }
            return new matrix(ret);
        }

        public static matrix operator -(matrix a)
        {
            double[,] ret = new double[a.size_x, a.size_y];
            for (int i = 0; i < a.size_x; i++)
            {
                for (int j = 0; j < a.size_y; j++)
                {
                     ret[i, j] = -a.data[i, j];
                }
            }
            return new matrix(ret);
        }

        public static bool operator ==(matrix a, matrix b)
        {
            bool ret = true;
            if ((a.size_x == b.size_x) && (a.size_y == b.size_y))
            {
                for (int i = 0; i < a.size_x; i++)
                {
                    for (int j = 0; j < a.size_y; j++)
                    {
                        if (a.data[i, j] == b.data[i, j]) {
                            ret = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            return ret;
        }

        public static bool operator !=(matrix a, matrix b)
        {
            bool ret = true;
            if ((a.size_x == b.size_x) && (a.size_y == b.size_y))
            {
                for (int i = 0; i < a.size_x; i++)
                {
                    for (int j = 0; j < a.size_y; j++)
                    {
                        if (a.data[i, j] == b.data[i, j])
                        {
                            ret = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                return true;
            }
            return !ret;
        }

        public override string ToString()
        {
            string ret = "";
            for (int i = 0; i < this.size_x; i++)
            {
                for (int j = 0; j < this.size_y; j++)
                {
                    ret = ret + string.Format("{0,10:F2}", this.data[i, j]);
                }
                ret = ret + Environment.NewLine;
            }
            return ret;
        }

        public double det() {
            double value_plus = 0;
            double value_minus = 0;
            if (this.size_x == this.size_y)
            {
                if (this.size_x == 3)
                {
                    value_plus += this.data[0, 0] * this.data[1, 1] * this.data[2, 2];
                    value_plus += this.data[0, 1] * this.data[1, 2] * this.data[2, 0];
                    value_plus += this.data[0, 2] * this.data[1, 0] * this.data[2, 1];
                    value_minus += this.data[0, 2] * this.data[1, 1] * this.data[2, 0];
                    value_minus += this.data[0, 0] * this.data[1, 2] * this.data[2, 1];
                    value_minus += this.data[0, 1] * this.data[1, 0] * this.data[2, 2];
                }
                if (this.size_x == 2) {
                    value_plus += this.data[0, 0]* this.data[1, 1];
                    value_minus += this.data[0, 1] * this.data[1, 0];
                }
                if (this.size_x == 1) {
                    value_plus = this.data[0, 0];
                }
                if(this.size_x > 3)
                {
                    throw new Exception("Matrix is not max dimension of 3");
                }
    
            }
            else {
                throw new Exception("Matrix is not squer");
            }
            return value_plus - value_minus;
        }

        public static matrix BasicMatrix(int dimension) {
            double[,] data = new double[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (i == j) {
                        data[i, j] = 1;
                    } else {
                        data[i, j] = 0;
                    };
                }
            }
        
            return new matrix(data);
        }
    }
}
