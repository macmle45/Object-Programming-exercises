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
            if(hh >=24 || mm >= 60 || ss >= 60)
            {
                throw new ArgumentOutOfRangeException("Argument out of range.");
            }
            else
            {
                this.hours = hh;
                this.minutes = mm;
                this.seconds = ss;
            }
        }

        //constructor for two-parameter option
        public Time(byte hh, byte mm) : this(hh, mm, default(byte)) { }

        //constructor for one-parameter option
        public Time(byte hh) : this(hh, default(byte), default(byte)) { }

        //constructor for string-parameter option ("hh:mm:ss")
        public Time(string t)
        {
            if (t.Length > 8)
                throw new ArgumentException("Invalid argument. Correct argument: 'hh:mm:ss'.");
            else
            {
                try
                {
                    this.hours = byte.Parse(t.Substring(0, 2));
                    this.minutes = byte.Parse(t.Substring(3, 2));
                    this.seconds = byte.Parse(t.Substring(6, 2));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

        public override bool Equals(object t)
        {
            if (t == null || this.GetType() != t.GetType()) return false;

            return (this.Hours == ((Time)t).Hours && this.Minutes == ((Time)t).Minutes && this.Seconds == ((Time)t).Seconds);
        }

        #region interfaces implementation
        public bool Equals(Time t)
        {
            return this.Equals(t);
        }

        public int CompareTo(Time t)
        {
            return 0;
        }
        #endregion

        #region overriding operators

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !t1.Equals(t2);
        }

        #endregion


    }
}
