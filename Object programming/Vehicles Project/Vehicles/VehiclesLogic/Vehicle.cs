using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public abstract class Vehicle
    {
        public abstract bool MotionStatus();
        public abstract double Speed();
        public abstract string Environment();

        public virtual bool Go
        {
            get
            {
                return MotionStatus();
            }
        }

        public virtual bool Stop
        {
            get
            {
                return MotionStatus();
            }
        }

        public virtual double SpeedUp
        {
            get
            {
                return Speed();
            }
        }

        public virtual double SpeedDown
        {
            get
            {
                return Speed();
            }
        }

        public virtual string SetEnvironment
        {
            get
            {
                return Environment();
            }
        }

        public override string ToString()
        {
            return $"Motion status: {MotionStatus()}\nSpeed: {Speed()}\nEnvironment: {Environment()}";
        }
    }
}
