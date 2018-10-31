using System;

namespace TimeAndSched.Backend.Model
{
    public class Time
    {
        public Time(bool defTime)
        {
            if (defTime)
            {
                DateTime time = new DateTime();
                Hours = (time.Hour > 12 ? (time.Hour - 12) : time.Hour);
                Minutes = time.Minute;
                Seconds = time.Second;
                TimeOfDay = (time.Hour >= 12 ? "PM" : "AM");
            }
            else
            {
                SetDefault();
            }
        }

        public Time(int hours, int minutes, int seconds, string tod)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            TimeOfDay = tod;
        }

        public Time(string time)
        {
            // check for TimeUtitly formatting with regex
            var timeElements = time.Split(':');
            var secondsAndTod = timeElements[timeElements.Length-1].Split(' ');

            Hours = int.Parse(timeElements[0]);
            Minutes = int.Parse(timeElements[1]);
            Seconds = int.Parse(secondsAndTod[0]);
            TimeOfDay = secondsAndTod[1];
        }

        private void SetDefault()
        {
            Hours = -1;
            Minutes = -1;
            Seconds = -1;
            TimeOfDay = "N/A";
        }

        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public string TimeOfDay { get; private set; }
        
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2} {4}", Hours, Minutes, Seconds, TimeOfDay);
        }
    }
}
