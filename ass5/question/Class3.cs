using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass5.question
{
    public class Duration
    {
      
        private int hours;
        private int minutes;
        private int seconds;

      
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

      
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            this.hours = totalSeconds / 3600;
            this.minutes = (totalSeconds % 3600) / 60;
            this.seconds = totalSeconds % 60;
        }

      
        public override string ToString()
        {
            if (hours > 0)
            {
                return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
            }
            else if (minutes > 0)
            {
                return $"Minutes: {minutes}, Seconds: {seconds}";
            }
            else
            {
                return $"Seconds: {seconds}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Duration))
            {
                return false;
            }

            Duration other = (Duration)obj;
            return this.hours == other.hours &&
                   this.minutes == other.minutes &&
                   this.seconds == other.seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hours, minutes, seconds);
        }

       
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToSeconds() + d2.ToSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds = d.ToSeconds() + seconds;
            return new Duration(totalSeconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            int totalSeconds = seconds + d.ToSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator ++(Duration d)
        {
            d.AddMinutes(1);
            return d;
        }

        public static Duration operator --(Duration d)
        {
            d.SubtractMinutes(1);
            return d;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToSeconds() - d2.ToSeconds();
            return new Duration(totalSeconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() >= d2.ToSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <= d2.ToSeconds();
        }

        public static implicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

        
        private int ToSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

       
        private void AddMinutes(int minutesToAdd)
        {
            int totalMinutes = hours * 60 + this.minutes + minutesToAdd;
            this.hours = totalMinutes / 60;
            this.minutes = totalMinutes % 60;
        }

        private void SubtractMinutes(int minutesToSubtract)
        {
            int totalMinutes = hours * 60 + this.minutes - minutesToSubtract;
            if (totalMinutes >= 0)
            {
                this.hours = totalMinutes / 60;
                this.minutes = totalMinutes % 60;
            }
            else
            {
                throw new InvalidOperationException("Cannot subtract more minutes than available.");
            }
        }
    }
}
