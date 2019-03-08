using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLogic.Interfaces;

namespace VehiclesLogic
{
    public class Car : Vehicle, IEngine, IWheels
    {
        private readonly string environment = "Land";
        private readonly string name = "Car";
        private bool motion_status = false;


        private int current_speed;
        private readonly int max_speed = 350;
        private readonly int min_speed = 1;
        private readonly string speed_units = "km/h";

        private int wheels_quantity;
        private string engine_type;
        private string engine_petrol_type;
        private double engine_power;

        private double fuel;
        private double weight;
        private string color;
        

        //constructor with two default arguments
        public Car(double fuel, double weight, string engine_type, string engine_petrol_type, double engine_power, int wheels_quantity = 4, string color = "black")
        {
            this.fuel = fuel;
            this.weight = weight;
            this.color = color;

            WheelsQuantity = wheels_quantity;

            EngineType = engine_type;
            EnginePetrolType = engine_petrol_type;
            EnginePower = engine_power;
        }

        //IEngine method implementations
        public string EngineType { get => engine_type; set => engine_type = value; }
        public string EnginePetrolType { get => engine_petrol_type; set => engine_petrol_type = value; }
        public double EnginePower { get => engine_power; set => engine_power = value; }

        //IWheels method implementations
        public int WheelsQuantity
        {
            get => wheels_quantity;
            set
            {
                if (value == 3 || value == 4)
                    wheels_quantity = value;
                else
                    throw new ArgumentException("Quantity of wheels must be 3 or 4");
                
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType()}\nEnvironment: {environment}\nType name: {name}\nWeight: {weight}kg\n" +
                   $"Quantity of wheels: {WheelsQuantity}\nEngine type: {EngineType}\nEngine petrol type: {EnginePetrolType}\n" +
                   $"Engine power: {EnginePower}KM\nFuel: {fuel}L\nColor: {color}\nMoving status: {motion_status}\n" +
                   $"Max speed: {max_speed}{speed_units}\nMin speed: {min_speed}{speed_units}\nCurrent speed: {current_speed}{speed_units}\n";
        }


        #region overridden methods from Vehicle base class
        //start moving method
        public override bool MovingVehicle()
        {
            current_speed = 1;
            motion_status = true;
            return motion_status;
        }

        //end moving method
        public override bool StoppingVehicle()
        {
            current_speed = 0;
            motion_status = false;
            return motion_status;
        }

        //speedup method
        public override int Faster(int step_speed)
        {
            if (current_speed > 0)
            {
                if (current_speed <= max_speed)
                {
                    current_speed += step_speed;
                    return current_speed;
                }
                else
                    return current_speed;
            }
            else
                return 0;
        }

        //speeddown method
        public override int Slower(int step_speed)
        {
            if (current_speed >= min_speed)
            {
                current_speed -= step_speed;
                return current_speed;
            }
            else
                return current_speed;
        }
        #endregion
    }
}
