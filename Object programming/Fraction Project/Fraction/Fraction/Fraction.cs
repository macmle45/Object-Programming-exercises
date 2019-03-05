using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public struct Fraction
    {
        //private fields
        private int numerator;
        private int denominator;

        //constructor with default argument
        public Fraction(int numerator, int denominator = 1)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator must be greater than zero");
            this.numerator = numerator;
            this.denominator = denominator;
        }

        //instances of Fraction struct
        public static readonly Fraction Zero = new Fraction(0);
        public static readonly Fraction One = new Fraction(1);
        public static readonly Fraction Half = new Fraction(1, 2);
        public static readonly Fraction Quarter = new Fraction(1, 4);

        //info about struct
        public static string Info()
        {
            return "This is my first test implementation of fraction\t(c)macmle45 2019";
        }

        //override ToString method
        public override string ToString()
        {
            return $"{numerator.ToString()}/{denominator.ToString()}";
        }

        //converting method
        public double ToDouble()
        {
            return numerator / (double)denominator;
        }

        //euclids algorithm
        public void SimplifyFraction()
        {
            int a = numerator;
            int b = denominator;

            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }

            numerator /= a;
            denominator /= a;

            //sign
            if ( numerator * denominator < 0)
            {
                numerator = -Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            else
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
        }
    }
}
