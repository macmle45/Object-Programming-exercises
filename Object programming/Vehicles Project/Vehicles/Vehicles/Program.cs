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
            
            Car ford = new Car("Ford Focus", 50.7, 2000, "Natural petrol", "Gas", 200, 4);
            ford.MovingVehicle();
            ford.Faster(159);

            Car volkswagen = new Car("Volkswagen Golf", 30, 1500, "Natural petrol", "Benzine", 130, 4);
            volkswagen.MovingVehicle();
            volkswagen.Faster(54);

            Airplane boeing = new Airplane("Boeing 737-400", 3000, 30000, "SuperJet", "high-octane petrol", 1500, 6, "white-blue");
            boeing.MovingVehicle();
            boeing.Faster(300);

            Airplane airbus = new Airplane("Airbus A320", 3000, 30000, "SuperJet", "high-octane petrol", 2500, 6, "white-red");
            airbus.MovingVehicle();
            airbus.Faster(30);

            Amphibian amphibia_basic = new Amphibian("Amfibia Normal", 50, 1500, 2000, "V6", 150, 4);
            amphibia_basic.MovingVehicle();
            amphibia_basic.Faster(195);

            Amphibian amphibia_turbo = new Amphibian("Amfibia Turbo", 50, 2000, 2800, "V8", 250, 4);
            amphibia_turbo.MovingVehicle();
            amphibia_turbo.Faster(100);
            amphibia_turbo.swimAmphibian();


            //creating list of Vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            //added vehicles to list
            vehicles.Add(ford);
            vehicles.Add(volkswagen);
            vehicles.Add(boeing);
            vehicles.Add(airbus);
            vehicles.Add(amphibia_basic);
            vehicles.Add(amphibia_turbo);

            Console.WriteLine("Original order in list vehicles:\n");
            for(int i= 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($"Type: {vehicles[i].GetType().Name}\nName: {vehicles[i].Name}\nSpeed: {vehicles[i].Speed} km/h\n");
            }

            Console.WriteLine("-------------------------------\nOnly land vehicles:\n");
            for (int i = 0; i < vehicles.Count; i++)
            {
                if(vehicles[i].Environment == "Land")
                    Console.WriteLine($"Type: {vehicles[i].GetType().Name}\nName: {vehicles[i].Name}\nSpeed: {vehicles[i].Speed} km/h\n");
            }

            Console.WriteLine("-------------------------------\nAll vehicles after sorting (ASC | speed):\n");

            //sorting
            vehicles.Sort();

            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($"Type: {vehicles[i].GetType().Name}\nName: {vehicles[i].Name}\nSpeed: {vehicles[i].Speed} km/h\n");
            }

            Console.WriteLine("-------------------------------\nOnly land vehicles after sorting (DESC | speed):\n");

            //sorting
            vehicles.Sort((a, b) => -1 * a.CompareTo(b));

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Environment == "Land")
                    Console.WriteLine($"Type: {vehicles[i].GetType().Name}\nName: {vehicles[i].Name}\nSpeed: {vehicles[i].Speed} km/h\n");
            }

            Console.ReadKey();
        }
    }
}
