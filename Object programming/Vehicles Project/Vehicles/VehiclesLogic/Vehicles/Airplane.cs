using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLogic.Interfaces;

namespace VehiclesLogic
{
    public class Airplane : Vehicle, IEngine, IWheels
    {
        private bool LandEnv;
        private bool AirEnv;

        private string name;
        private bool motion_status = false;


        private double current_speed;

        private double max_speed_air = 200;
        private static double min_speed_air = 20;
        private readonly string air_speed_unit = "m/s";

        private double max_speed_land = SpeedUnitConvert("Air", "Land", min_speed_air);
        private double min_speed_land = 1;
        private string land_speed_unit = "km/h";

        private string current_speed_unit = "km/h";

        private int wheels_quantity;

        private double fuel;
        private double weight;
        private string color;

        //IEngine method implementations
        //auto-implemented properties
        public string EngineType { get; set; }
        public string EnginePetrolType { get; set; }
        public double EnginePower { get; set; }

        //constructor
        public Airplane(string name, double fuel, double weight, string engine_type, string engine_petrol_type, double engine_power, int wheels_quantity = 3, string color = "black")
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
                if (value == 3 || value == 6 )
                    wheels_quantity = value;
                else
                    throw new ArgumentException("Quantity of wheels must be 3 or 6");

            }
        }

        public override string ToString()
        {
            return $"Type: {base.ToString()}\nEnvironment:\n\tLand: {LandEnv}\n\tAir: {AirEnv}\nType name: {name}\nWeight: {weight}kg\n" +
                   $"Quantity of wheels: {WheelsQuantity}\nEngine type: {EngineType}\nEngine petrol type: {EnginePetrolType}\n" +
                   $"Engine power: {EnginePower}KM\nFuel: {fuel}L\nColor: {color}\nMoving status: {motion_status}\n" +
                   $"Max speed (land): {max_speed_land}{land_speed_unit}\nMin speed (land): {min_speed_land}{land_speed_unit}\nMax speed (air): {max_speed_air}{air_speed_unit}\nMin speed (air): {min_speed_air}{air_speed_unit}\n" +
                   $"Current speed: {current_speed}{current_speed_unit}\n";
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
            if (AirEnv)
            {
                throw new InvalidOperationException("First, you should land | Reduce the speed");
            }
            else
            {
                current_speed = 0;
                motion_status = false;
            }
            return motion_status;
        }

        //speedup method
        public override double Faster(double step_speed)
        {

            if (LandEnv)
            {
                if (current_speed + step_speed < max_speed_land)
                {
                    current_speed += step_speed;
                    return current_speed;
                }
                else
                {
                    //convert km/h -> m/s
                    double temp_speed = SpeedUnitConvert("Land", "Air", current_speed + step_speed);

                    if(temp_speed > max_speed_air)
                        throw new InvalidOperationException("The step speed is too big | Enter lower step speed value");
                    else
                    {
                        current_speed = temp_speed;
                        current_speed_unit = air_speed_unit;
                        SetEnvironment("Land", false);
                        SetEnvironment("Air", true);
                        return current_speed;
                    }
                }
            }
            else
            {
                if (current_speed + step_speed > max_speed_air)
                    throw new InvalidOperationException("The step speed is too big | Enter lower step speed value");
                else
                {
                    current_speed += step_speed;
                    return current_speed;
                }
            }
        }

        //speeddown method
        public override double Slower(double step_speed)
        {
            if (LandEnv)
            {
                if(current_speed - step_speed < min_speed_land)
                {
                    throw new InvalidOperationException("You can't low speed as much");
                }
                else
                {
                    current_speed -= step_speed;
                    return current_speed;
                }
            }
            else
            {
                //convert m/s -> km/h
                double temp_speed = SpeedUnitConvert("Air", "Land", current_speed - step_speed);

                if(temp_speed < min_speed_land)
                {
                    throw new InvalidOperationException("You can't low speed as much");
                }
                else
                {
                    if (current_speed - step_speed < min_speed_air)
                    {
                        current_speed = temp_speed;
                        current_speed_unit = land_speed_unit;
                        SetEnvironment("Air", false);
                        SetEnvironment("Land", true);
                        return current_speed;
                    }
                    else
                    {
                        current_speed -= step_speed;
                        return current_speed;
                    }
                }
            }
        }

        //Set environment method
        protected override bool SetEnvironment(string env, bool option)
        {
            switch (env)
            {
                case "Land":
                    LandEnv = option;
                    return LandEnv;

                case "Air":
                    AirEnv = option;
                    return AirEnv;
            }

            return option;
        }
        #endregion
    }
}
