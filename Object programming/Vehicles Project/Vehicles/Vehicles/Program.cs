using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLogic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car my_car = new Car(35.6, 1500, "blue");

            Console.WriteLine(my_car.ToString());

            my_car.MovingVehicle();
            my_car.Faster();

            Console.WriteLine(my_car.ToString());



            Console.ReadKey();
        }
    }
}
