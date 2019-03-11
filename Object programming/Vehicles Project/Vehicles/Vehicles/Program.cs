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
            
            Car my_car = new Car("Ford", 50.7, 2000, "Natural petrol", "Gas", 200, 4);

            my_car.MovingVehicle();
            my_car.Faster(25);
            my_car.Slower(7);

            //Console.WriteLine(my_car.ToString());

            Airplane my_airplane = new Airplane("Boeing 737-400", 3000, 30000, "SuperJet", "high-octane petrol", 1500, 6, "white-blue");

            my_airplane.MovingVehicle();
            my_airplane.Faster(18);

            Console.WriteLine(my_airplane.ToString());

            my_airplane.Faster(300);
            Console.WriteLine(my_airplane.ToString());

            my_airplane.Slower(70.7);
            Console.WriteLine(my_airplane.ToString());

            Amphibian my_amphibian = new Amphibian("Amfibia Fireball", 50, 1500, 2000, "V6", 150, 4);
            Console.WriteLine(my_amphibian.ToString());

            Console.ReadKey();
        }
    }
}
