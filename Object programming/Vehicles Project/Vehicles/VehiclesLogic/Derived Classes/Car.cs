using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public class Car : Vehicle
    {
        private readonly string environment = "Land";
        private readonly string name = "Car";
        private string motion_status = "Car is not moving";
        
        
        private int current_speed;
        private readonly int max_speed = 350;
        private readonly int min_speed = 1;

        private int wheel_quantity;
        private string engine;

        private double fuel;
        private double weight;
        private string color;
        




        //constructor
        public Car(double car_fuel, double car_weight, string car_color = "black")
        {
            fuel = car_fuel;
            weight = car_weight;
            color = car_color;
        }

        public override string MovingVehicle()
        {
            current_speed = 1;
            motion_status = $"{name} is moving";
            return motion_status;
        }

        public override string StoppingVehicle()
        {
            current_speed = 0;
            motion_status = $"{name} is not moving";
            return motion_status;
        }

        public override int Faster()
        {
            if (current_speed > 0)
            {
                if (current_speed <= max_speed)
                {
                    current_speed += 3;
                    return current_speed;
                }
                else
                    return current_speed;
            }
            else
                return 0;
        }

        public override int Slower()
        {
            if (current_speed >= min_speed)
            {
                current_speed -= 3;
                return current_speed;
            }
            else
                return current_speed;
        }

        public override string ToString()
        {
            return $"Environment: {environment}\nType: {name}\nWeight: {weight}kg\nFuel: {fuel}L\nColor: {color}\nStatus: {motion_status}\nCurrent speed: {current_speed}";
        }
    }
}
