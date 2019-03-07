using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    class Car : Vehicle
    {
        public string type;
        public bool motion_status;
        public double current_speed;
        public string environment;


        public override bool MotionStatus()
        {
            return motion_status;
        }

        public override double Speed()
        {
            return current_speed;
        }

        public override string Environment()
        {
            return environment;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nType: {type}";
        }
    }
}
