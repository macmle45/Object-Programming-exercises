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
            Car my_car = new Car(35.6, 1500, "Electric", "Electricity", 150, 4, "blue");
            Car my_car_2 = new Car(50.7, 2000, "Natural petrol", "Gas", 200, 3, "red");

            //my_car.MovingVehicle();

            my_car_2.MovingVehicle();
            my_car_2.Faster();
            

            Console.WriteLine(my_car.ToString());
            Console.WriteLine(my_car_2.ToString());



            Console.ReadKey();
        }
    }
}
