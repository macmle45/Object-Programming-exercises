using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLogic
{
    public abstract class Vehicle
    {
        private int s;

        public abstract bool MovingVehicle();
        public abstract bool StoppingVehicle();

        public abstract int Faster(int s);
        public abstract int Slower(int s);

        

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
                return Faster(s);
            }
        }

        public virtual int SpeedDown
        {
            get
            {
                return Slower(s);
            }
        }
    }
}
