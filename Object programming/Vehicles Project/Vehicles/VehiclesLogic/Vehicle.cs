using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public abstract class Vehicle : IComparable<Vehicle>
    {
        private readonly double s = 0;
        private readonly string env = "Land";
        private readonly bool option = true;

        public abstract bool MovingVehicle();
        public abstract bool StoppingVehicle();

        public abstract double Faster(double s);
        public abstract double Slower(double s);

        protected abstract bool SetEnvironment(string env, bool option);
        

        public virtual bool Go
        {
            get => MovingVehicle();
        }

        public virtual bool Stop
        {
            get => StoppingVehicle();
        }

        public virtual double SpeedUp
        {
            get => Faster(s);
        }

        public virtual double SpeedDown
        {
            get => Slower(s);
        }

        public virtual bool Environment
        {
            get => SetEnvironment(env, option);
        }

        //type 0: km/h -> m/s
        //type 1: m/s -> km/h
        protected static double SpeedUnitConvert(int type, double s)
        {
            
            switch (type)
            {
                case 0:
                    s = (s * 1000) / 3600;
                    break;
                case 1:
                    s = (s * 3600) / 1000;
                    break;
            }
            return s;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public int CompareTo(Vehicle v)
        {
            return 0;
        }
    }
}
