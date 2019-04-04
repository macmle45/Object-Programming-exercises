using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLogic.Interfaces;

namespace VehiclesLogic
{
    public class Amphibian : Vehicle, IEngine, IWheels
    {
        private bool LandEnv;
        private bool WaterEnv;

        //for converting speed to comparing
        private string temp_speed_unit;

        private string name;
        private bool motion_status = false;
        private double displacement;


        private double current_speed;

        private double max_speed_water = 40;
        private double min_speed_water = 1;
        private readonly string water_speed_unit = "knots";

        private double max_speed_land = 350;
        private double min_speed_land = 1;
        private readonly string land_speed_unit = "km/h";

        private string current_speed_unit = "km/h";

        private int wheels_quantity;

        private double fuel;
        private double weight;
        private string color;


        //constructor
        public Amphibian(string name, double fuel, double weight, double displacement, string engine_type, double engine_power, int wheels_quantity = 4, string color = "red")
        {
            LandEnv = true;
            temp_speed_unit = current_speed_unit;

            this.name = name;

            this.fuel = fuel;
            this.weight = weight;
            this.displacement = displacement;
            this.color = color;

            WheelsQuantity = wheels_quantity;

            EngineType = engine_type;
            EnginePetrolType = "Oil";
            EnginePower = engine_power;
        }

        //IEngine method implementations
        //auto-implemented properties
        public string EngineType { get; set; }
        public string EnginePetrolType { get; set; }
        public double EnginePower { get; set; }

        //IWheels method implementations
        public int WheelsQuantity
        {
            get => wheels_quantity;
            set
            {
                if (value != 4 )
                    throw new ArgumentException("Quantity of wheels must equals 4");
                else
                    wheels_quantity = value;
            }
        }

        public void swimAmphibian()
        {
            SetEnvironment("Land", false);
            SetEnvironment("Water", true);
        }

        public void rideAmphibian()
        {
            SetEnvironment("Water", false);
            SetEnvironment("Land", true);
        }

        public override string ToString()
        {
            return $"Type: {base.ToString()}\nEnvironment:\n\tLand: {LandEnv}\n\tWater: {WaterEnv}\nType name: {name}\nWeight: {weight}kg\nDisplacement: {displacement}kg\n" +
                   $"Quantity of wheels: {WheelsQuantity}\nEngine type: {EngineType}\nEngine petrol type: {EnginePetrolType}\n" +
                   $"Engine power: {EnginePower}KM\nFuel: {fuel}L\nColor: {color}\nMoving status: {motion_status}\n" +
                   $"Max speed (land): {max_speed_land}{land_speed_unit}\nMin speed (land): {min_speed_land}{land_speed_unit}\n" +
                   $"Max speed (water): {max_speed_water}{water_speed_unit}\nMin speed (water): {min_speed_water}{water_speed_unit}\n" +
                   $"Current speed: {current_speed}{current_speed_unit}\n";
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
                if (LandEnv)
                {
                    if (current_speed + step_speed < max_speed_land)
                    {
                        current_speed += step_speed;
                        return current_speed;
                    }
                    else
                    {
                        current_speed = max_speed_land;
                        return current_speed;
                    } 
                }
                else
                {
                    if (current_speed + step_speed < max_speed_water)
                    {
                        current_speed += step_speed;
                        return current_speed;
                    }
                    else
                    {
                        current_speed = max_speed_water;
                        return current_speed;
                    }
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
                if (LandEnv)
                {
                    if (current_speed - step_speed > min_speed_land)
                    {
                        current_speed -= step_speed;
                        return current_speed;
                    }
                    else
                    {
                        current_speed = min_speed_land;
                        return current_speed;
                    }
                }
                else
                {
                    if (current_speed - step_speed > min_speed_water)
                    {
                        current_speed -= step_speed;
                        return current_speed;
                    }
                    else
                    {
                        current_speed = min_speed_water;
                        return current_speed;
                    }
                }
            }
            else
            {
                //First put the vehicle into motion
                return 0;
            }
        }

        //Set environment method
        public override string SetEnvironment(string env, bool option)
        {
            if(LandEnv && WaterEnv)
            {
                //vehicle can not be in two environments simultaneously
                return null;
            }
            else
            {
                if (env=="Land" && option)
                {
                    current_speed = SpeedUnitConvert("Water", "Land", current_speed);
                    current_speed_unit = land_speed_unit;
                    temp_speed_unit = current_speed_unit;
                    WaterEnv = false;
                    LandEnv = option;
                    //return LandEnv;
                }
                else
                {
                    if(env=="Water" && option)
                    {  
                        double temp_speed = SpeedUnitConvert("Land", "Water", current_speed);
                        if (temp_speed > max_speed_water)
                            current_speed = max_speed_water;
                        else
                            current_speed = temp_speed;

                        current_speed_unit = water_speed_unit;
                        temp_speed_unit = current_speed_unit;
                        LandEnv = false;
                        WaterEnv = option;
                        //return LandEnv;
                    }
                }
            }

            if (LandEnv)
                return "Land";
            else
                return "Water";
        }

        public override double GetSpeed()
        {
            //convert units to km/h
            if (temp_speed_unit == "km/h") 
            {
                return current_speed;
            }
            else
            {
                current_speed = SpeedUnitConvert("Water", "Land", current_speed);
                temp_speed_unit = "km/h";
                return current_speed;
            }
        }

        #endregion
    }
}
