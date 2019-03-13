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
        private bool LandEnv;

        private string name;
        private bool motion_status = false;
        public int abc;

        private double current_speed;
        private readonly double max_speed = 350;
        private readonly double min_speed = 1;
        private readonly string speed_units = "km/h";

        private int wheels_quantity;

        private double fuel;
        private double weight;
        private string color;

        //IEngine method implementations
        //auto-property
        public string EngineType { get; set; }
        public string EnginePetrolType { get; set; }
        public double EnginePower { get; set; }

        //constructor
        public Car(string name,  double fuel, double weight, string engine_type, string engine_petrol_type, double engine_power, int wheels_quantity = 4, string color = "black")
        {
            SetEnvironment("Land", true);

            this.name = name;

            this.fuel = fuel;
            this.weight = weight;
            this.color = color;

            WheelsQuantity = wheels_quantity;

            EngineType = engine_type;
            EnginePetrolType = engine_petrol_type;
            EnginePower = engine_power;
        }

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
            return $"Type: {base.ToString()}\nEnvironment:\n\tLand: {LandEnv}\nType name: {name}\nWeight: {weight}kg\n" +
                   $"Quantity of wheels: {WheelsQuantity}\nEngine type: {EngineType}\nEngine petrol type: {EnginePetrolType}\n" +
                   $"Engine power: {EnginePower}KM\nFuel: {fuel}L\nColor: {color}\nMoving status: {motion_status}\n" +
                   $"Max speed: {max_speed}{speed_units}\nMin speed: {min_speed}{speed_units}\nCurrent speed: {current_speed}{speed_units}\n";
        }


        #region overridden methods from Vehicle base class
        //
        public override string GetName()
        {
            return name;
        }

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
        public override double Faster(double step_speed)
        {
            //vehicle must be into motion
            if (current_speed > 0)
            {
                if (current_speed + step_speed <= max_speed)
                {
                    current_speed += step_speed;
                    return current_speed;
                }
                else
                {
                    current_speed = max_speed;
                    return current_speed;
                }
            }
            else
            {
                //First put the vehicle into motion
                return 0;
            }
        }

        //speeddown method
        public override double Slower(double step_speed)
        {
            //vehicle must be into motion
            if (current_speed > 0)
            {
                if (current_speed - step_speed >= min_speed)
                {
                    current_speed -= step_speed;
                    return current_speed;
                }
                else
                {
                    current_speed = min_speed;
                    return current_speed;
                }
            }
            else
            {
                //First put the vehicle into motion
                return 0;
            }
        }

        //Set environment method
        public override bool SetEnvironment(string env, bool option)
        {
            switch (env)
            {
                case "Land":
                    LandEnv = option;
                    return LandEnv;
            }

            return option;
        }

        //units: km/h
        public override double GetSpeed()
        {
            return current_speed;
        }
        #endregion
    }
}
