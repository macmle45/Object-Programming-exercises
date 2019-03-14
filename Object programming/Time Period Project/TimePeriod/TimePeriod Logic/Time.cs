using System;

namespace TimePeriod_Logic
{
    public struct Time : IEquatable<Time>, IComparable<Time>
    {
        private byte hours;
        private byte minutes;
        private byte seconds;

        //immutable
        public byte Hours { get => hours; }
        public byte Minutes { get => minutes; }
        public byte Seconds { get => seconds; }

        //basic constructor
        public Time(byte hh, byte mm, byte ss)
        {
            this.hours = hh;
            this.minutes = mm;
            this.seconds = ss;
        }

        //constructor for two-parameter option
        public Time(byte hh, byte mm) : this(hh, mm, default(byte)) { }

        //constructor for one-parameter option
        public Time(byte hh) : this(hh, default(byte), default(byte)) { }

        //constructor for string-parameter option ("hh:mm:ss")
        public Time(string t)
        {
            this.hours = byte.Parse(t.Substring(0, 2));
            this.minutes = byte.Parse(t.Substring(3, 2));
            this.seconds = byte.Parse(t.Substring(6, 2));
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        #region interfaces implementation
        public bool Equals(Time t)
        {
            
            return true;
        }

        public int CompareTo(Time t)
        {
            return 0;
        }
        #endregion

        #region overriding operators
        #endregion


    }
}
