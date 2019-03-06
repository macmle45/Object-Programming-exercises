using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(4, 2);
            Fraction f2 = new Fraction(22, 7);
            Fraction f3 = new Fraction(8, 24);

            f3.SimplifyFraction();

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToDouble());
            Console.WriteLine(f3.ToString());

            Console.WriteLine((f2 - f3).ToString());


            Console.WriteLine($"\n\n\n>>>\t{Fraction.Info()}\t<<<");
            Console.ReadKey();
        }
    }
}
