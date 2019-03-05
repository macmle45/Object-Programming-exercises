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
            Fraction two = new Fraction(4, 2);

            
            Console.WriteLine($"{two.ToString()}");


            Console.WriteLine($"\n\n\n>>>\t{Fraction.Info()}\t<<<");
            Console.ReadKey();
        }
    }
}
