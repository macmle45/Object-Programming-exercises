using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public abstract class Vehicle : IComparable<Vehicle>
    {
        protected double s;
        private readonly string env;
        private readonly bool option;

        public abstract string GetName();

        public abstract bool MovingVehicle();
        public abstract bool StoppingVehicle();

        public abstract double Faster(double s);
        public abstract double Slower(double s);

        public abstract string SetEnvironment(string env, bool option);

        public abstract double GetSpeed();

        public virtual string Name
        {
            get => GetName();
        }

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

        public virtual string Environment
        {
            get => SetEnvironment(env, option);
        }

        public virtual double Speed
        {
            get => GetSpeed();
        }

        //type 0: km/h -> m/s
        //type 1: m/s -> km/h
        protected static double SpeedUnitConvert(string env_from, string env_to, double s)
        {
            if (env_from == "Land" && env_to == "Air")
            {
                s = (s * 1000) / 3600;
                return s;
            }
            else
            {
                if (env_from == "Air" && env_to == "Land")
                {
                    s = (s * 3600) / 1000;
                    return s;
                }
                else
                {
                    if (env_from == "Land" && env_to == "Water")
                    {
                        s /= 1.8519984;
                        return s;
                    }
                    else
                    {
                        if (env_from == "Water" && env_to == "Land")
                        {
                            s *= 1.8519984;
                            return s;
                        }
                    }
                }  
            }
            return s;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public int CompareTo(Vehicle v)
        {
            double diff = this.Speed - v.Speed;
            if (diff != 0) diff /= Math.Abs(diff);
            return (int)(diff);
        }
    }
}
