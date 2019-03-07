using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public abstract class Vehicle
    {
        public abstract string MovingVehicle();
        public abstract string StoppingVehicle();

        public abstract int Faster();
        public abstract int Slower();



        public virtual string Go
        {
            get
            {
                return MovingVehicle();
            }
        }

        public virtual string Stop
        {
            get
            {
                return StoppingVehicle();
            }
        }

        public virtual int SpeedUp
        {
            get
            {
                return Faster();
            }
        }

        public virtual int SpeedDown
        {
            get
            {
                return Slower();
            }
        }
    }
}
