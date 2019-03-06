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



            Console.WriteLine($"Operations on two fraction: {f2}, {f3}\n");

            Console.WriteLine($"Negative:\t{(-f2).ToString()} or {(-f3).ToString()}");
            Console.WriteLine($"Minus:\t\t{(f2 - f3).ToString()}");
            Console.WriteLine($"Plus:\t\t{(f2 + f3).ToString()}");
            Console.WriteLine($"Multiplication:\t{(f2 * f3).ToString()}");
            Console.WriteLine($"Divide:\t\t{(f2 / f3).ToString()}");


            Console.WriteLine($"\n\n\n>>>\t{Fraction.Info()}\t<<<");
            Console.ReadKey();
        }
    }
}
