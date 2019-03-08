using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public abstract class Vehicle
    {
        public abstract bool MovingVehicle();
        public abstract bool StoppingVehicle();

        public abstract int Faster();
        public abstract int Slower();



        public virtual bool Go
        {
            get
            {
                return MovingVehicle();
            }
        }

        public virtual bool Stop
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
