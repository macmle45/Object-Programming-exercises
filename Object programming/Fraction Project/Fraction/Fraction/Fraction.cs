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
    }
}
