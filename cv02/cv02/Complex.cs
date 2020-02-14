using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class Complex
    {

        public double re;
        public double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.re + b.re, a.im + b.im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.re - b.re, a.im - b.im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.re * b.re) - (a.im * b.im), (a.re * b.im) + (a.im * b.re));
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double value = (b.re * b.re) + (b.im * b.im);
            return new Complex(((a.re * b.re) + (a.im * b.im))/value, ((a.im * b.re) - (a.re * b.im))/value);
        }

        public static Complex operator -(Complex a)
        {
            return new Complex(-a.re,-a.im);
        }

        public static bool operator ==(Complex a, Complex b)
        {
            double reDiff = a.re - b.re;
            double imDiff = a.im - b.im;
            if (reDiff < 0) {
                reDiff = reDiff * (-1); 
            }
            if (imDiff < 0)
            {
                imDiff = imDiff * (-1);
            }
            if ((reDiff < 1E-6) && (imDiff < 1E-6)){
                return true;
            }
            else {
                return false;
            }

        }

        public static bool operator !=(Complex a, Complex b)
        {
            double reDiff = a.re - b.re;
            double imDiff = a.im - b.im;
            if (reDiff < 0)
            {
                reDiff = reDiff * (-1);
            }
            if (imDiff < 0)
            {
                imDiff = imDiff * (-1);
            }
            if ((reDiff > 1E-6) || (imDiff > 1E-6))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            if (this.im < 0)
            {
                return string.Format("{0:F5}-{1:F5}j", this.re, -this.im);
            }
            else if (this.im == 0)
            {
                return string.Format("{0:F5}", this.re);
            }
            else
            {
                return string.Format("{0:F5}+{1:F5}j", this.re, this.im);
            }
        }

        public double mod()
        {
            double ret = Math.Sqrt((this.re * this.re) + (this.im* this.im));
            return ret;
        }
        public double arg()
        {
            double ret = Math.Acos(this.re / this.mod());
            return ret;
        }
        public Complex mirror() {
            return new Complex(this.re,-this.im);
        }
    }
}
