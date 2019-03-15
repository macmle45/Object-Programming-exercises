using System;
using System.Collections.Generic;
using System.Text;

namespace TimePeriod_Logic
{
    public struct TimePeriod
    {
        private long hours;
        private long minutes;
        private long seconds;

        //immutable
        public long Hours { get => hours; }
        public long Minutes { get => minutes; }
        public long Seconds { get => seconds; }

        public TimePeriod(long hhhh, long mm, long ss)
        {
            if(mm >= 60 || ss >= 60)
            {
                throw new ArgumentException("Invalid argument | out of range");
            }
            else
            {
                //this.hours
                //this.minutes
                //this.seconds
            }
        }
    }
}
