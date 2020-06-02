using Shared.Model;
using System;

namespace Shared.Global
{
    /// <summary>
    /// The time and date utility
    /// </summary>
    public static class TimeAndDateUtility
    {
        #region Time

        /// <summary>
        /// The current string time
        /// </summary>
        /// <returns>The current time</returns>
        public static string GetCurrentTimeString()
        {
            DateTime now = DateTime.Now;
            return string.Format(
                "{0}:{1}:{2} {3}",
                now.Hour == 0 || now.Hour > 12 ? Math.Abs(now.Hour - 12) : now.Hour,
                now.Minute.ToString().PadLeft(2, '0'),
                now.Second.ToString().PadLeft(2, '0'),
                now.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            );
        }

        /// <summary>
        /// The current time object
        /// </summary>
        /// <returns>The current time</returns>
        public static Time GetCurrentTime()
        {
            DateTime now = DateTime.Now;
            return new Time
            {
                Hours = now.Hour == 0 || now.Hour > 12 ? Math.Abs(now.Hour - 12) : now.Hour,
                Minutes = now.Minute,
                Seconds = now.Second,
                TimeofDay = now.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            };
        }

        /// <summary>
        /// Converts datetime to time string
        /// </summary>
        /// <param name="time">The time to convert</param>
        /// <returns>The string converted time</returns>
        public static string ConvertDateTime_TimeString(DateTime time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                (time.Hour == 0 || time.Hour > 12 ? Math.Abs(time.Hour - 12) : time.Hour).ToString().PadLeft(2, '0'),
                time.Minute.ToString().PadLeft(2, '0'),
                time.Second.ToString().PadLeft(2, '0'),
                time.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            );
        }

        /// <summary>
        /// Converts time to time string
        /// </summary>
        /// <param name="time">The time to convert</param>
        /// <returns>The string converted time</returns>
        public static string ConvertTime_String(Time time)
        {
            string timeString = string.Empty;

            if (time != null)
            {
                timeString = 
                    string.Format(
                        "{0}:{1}:{2} {3}",
                        time.Hours.ToString().PadLeft(2, '0'),
                        time.Minutes.ToString().PadLeft(2, '0'),
                        time.Seconds.ToString().PadLeft(2, '0'),
                        time.TimeofDay
                    );
            }
            return timeString;
        }

        /// <summary>
        /// Converts datetime to a time object
        /// </summary>
        /// <param name="time">The datetime time</param>
        /// <returns>The converted time</returns>
        public static Time ConvertDateTime_Time(DateTime time)
        {
            return new Time
            {
                Hours = time.Hour == 0 || time.Hour > 12 ? Math.Abs(time.Hour - 12) : time.Hour,
                Minutes = time.Minute,
                Seconds = time.Second,
                TimeofDay = time.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            };
        }

        /// <summary>
        /// Converts the datetime to 
        /// </summary>
        /// <param name="time">The string time</param>
        /// <returns>The converted string time</returns>
        public static Time ConvertString_Time(string time)
        {
            Time aTime = null;

            if (!string.IsNullOrEmpty(time))
            {
                string[] timeElements = time.Split(':');
                string[] secondsAndTod = timeElements[2].Split(' ');

                aTime = new Time
                {
                    Hours = int.Parse(timeElements[0]),
                    Minutes = int.Parse(timeElements[1]),
                    Seconds = int.Parse(secondsAndTod[0]),
                    TimeofDay = secondsAndTod[1]
                };
            }

            return aTime;
        }

        #endregion Time

        #region Date

        /// <summary>
        /// Gets the current date
        /// </summary>
        /// <param name="shorten">Whether to use short formatting</param>
        /// <returns>The current date string</returns>
        public static string GetCurrentDateString(bool shorten = false)
        {
            DateTime date = DateTime.Now;
            string dateString = shorten
                ? string.Format(
                    "{0} / {1} / {2}",
                    (int)TimeAndDateGlobals.GetMonth(TimeAndDateGlobals.GetMonth(date.Month)),
                    date.Day,
                    date.Year
                )
                : string.Format(
                    "{0}, {1} {2}, {3}",
                    TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                    TimeAndDateGlobals.GetMonth(date.Month),
                    date.Day,
                    date.Year
                );

            return dateString;
        }

        /// <summary>
        /// Gets the current date
        /// </summary>
        /// <returns>The current date object</returns>
        public static Date GetCurrentDate()
        {
            DateTime now = DateTime.Now;

            return new Date
            {
                Month = TimeAndDateGlobals.GetMonth(now.Month),
                Day = now.Day,
                Year = now.Year,
                DayOfWeek = now.DayOfWeek.ToString()
            };
        }
        
        /// <summary>
        /// Converts a string date into a date object
        /// </summary>
        /// <param name="date">The string date</param>
        /// <returns>The date object</returns>
        public static Date ConvertString_Date(string date)
        {
            Date aDate = null;
            if (!string.IsNullOrEmpty(date))
            {
                string[] dateElements = date.Split(',');
                string dow = dateElements[0];
                string[] monthAndDay = dateElements[1].TrimStart(' ').Split(' ');
                string month = monthAndDay[0];
                int day = int.Parse(monthAndDay[1]);
                int year = int.Parse(dateElements[2].TrimStart(' '));

                aDate = new Date
                {
                    Month = month,
                    Day = day,
                    Year = year,
                    DayOfWeek = dow
                };
            }
            
            return aDate;
        }

        /// <summary>
        /// Converts a datetime into a date object
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>A date object</returns>
        public static Date ConvertDateTime_Date(DateTime date)
        {
            return new Date
            {
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                Month = TimeAndDateGlobals.GetMonth(date.Month),
                Day = date.Day,
                Year = date.Year
            };
        }

        /// <summary>
        /// Converts a datetime into a date string
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>The date string</returns>
        public static string ConvertDateTime_String(DateTime date, bool shorten = false)
        {
            string dateString = shorten
                ? string.Format(
                    "{0} / {1} / {2}",
                    (int)TimeAndDateGlobals.GetMonth(TimeAndDateGlobals.GetMonth(date.Month)),
                    date.Day,
                    date.Year
                )
                : string.Format(
                    "{0}, {1} {2}, {3}",
                    TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                    TimeAndDateGlobals.GetMonth(date.Month),
                    date.Day,
                    date.Year
                );

            return dateString;
        }

        /// <summary>
        /// Converts a datetime into a date string
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>The date string</returns>
        public static string ConvertDate_String(Date date, bool shorten = false)
        {
            string dateString = string.Empty;

            if (date != null)
            {
                dateString = shorten
                ? string.Format(
                    "{0} / {1} / {2}",
                    (int)TimeAndDateGlobals.GetMonth(date.Month),
                    date.Day,
                    date.Year
                )
                : string.Format(
                    "{0}, {1} {2}, {3}",
                    date.DayOfWeek,
                    date.Month,
                    date.Day,
                    date.Year
                );
            }

            return dateString;
        }

        #endregion Date

        #region DateAndTime

        /// <summary>
        /// Converts a DateTime to a DateTime
        /// </summary>
        /// <param name="dateTime">The date to convert</param>
        /// <returns>A DateAndTime object</returns>
        public static DateAndTime ConvertDateTime_DateAndTime(DateTime dateTime)
        {
            Date date = ConvertDateTime_Date(dateTime);
            Time time = ConvertDateTime_Time(dateTime) ?? new Time { Hours = 12, Minutes = 0, Seconds = 0, TimeofDay = TimeAndDateGlobals.GetTimeOfDay((int)TimeOfDay.AM) };

            DateAndTime dateAndTime = new DateAndTime(date, time);

            return dateAndTime;
        }

        #endregion DateAndTime

        #region DateTime

        /// <summary>
        /// Converts a Date and Time object into a DateTime object
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>A datetime object</returns>
        public static DateTime ConvertDate_DateTime(Date date)
        {
            DateTime newDate = new DateTime(
                date.Year,
                (int) TimeAndDateGlobals.GetMonth(date.Month),
                date.Day
            );

            return newDate;
        }

        /// <summary>
        /// Converts a Date and Time object into a DateTime object
        /// </summary>
        /// <param name="date">The date</param>
        /// <param name="time">The time</param>
        /// <returns>A datetime object</returns>
        public static DateTime ConvertDateAndTime_DateTime(DateAndTime dateAndTime)
        {
            Date date = dateAndTime.Date;
            Time time = dateAndTime.Time;

            DateTime newDate = new DateTime(
                date.Year,
                (int)TimeAndDateGlobals.GetMonth(date.Month),
                date.Day,
                time == null ? 0 : time.Hours,
                time == null ? 0 : time.Minutes,
                time == null ? 0 : time.Seconds
            );

            newDate = time == null ? 
                newDate : 
                    (TimeAndDateGlobals.GetTimeOfDay(time.TimeofDay) == 0 && time.Hours == 12 ?
                        newDate.AddHours(-12) : (TimeAndDateGlobals.GetTimeOfDay(time.TimeofDay) == 0 ?
                            newDate : newDate.AddHours(12)));

            return newDate;
        }

        #endregion DateTime

        #region Comparisons


        /// <summary>
        /// Checks if date is within range
        /// </summary>
        /// <param name="beginDateAndTime">The start date and time</param>
        /// <param name="incomingDateAndTime">Date and time to examine</param>
        /// <param name="endDateAndTime">The end date and time</param>
        /// <param name="specific">WHether to compare a specific date and time</param>
        /// <returns>Whether the incoming date is within range</returns>
        public static bool IsWithinRange(DateAndTime beginDateAndTime, DateAndTime incomingDateAndTime, DateAndTime endDateAndTime, bool specific = true)
        {
            DateTime begin = ConvertDateAndTime_DateTime(beginDateAndTime);
            DateTime end = ConvertDateAndTime_DateTime(endDateAndTime);
            DateTime curr = ConvertDateAndTime_DateTime(incomingDateAndTime);

            bool beginMatchRange = curr >= (specific ? begin : begin.AddHours(-begin.Hour).AddMinutes(-begin.Minute).AddSeconds(-begin.Second));
            bool endMatchRange = curr <= (specific ? end : end.AddHours(23 - end.Hour).AddMinutes(59 - end.Minute).AddSeconds(59 - end.Second));

            return beginMatchRange && endMatchRange;
        }

        /// <summary>
        /// Checks if date is before range
        /// </summary>
        /// <param name="beginDate">The start date</param>
        /// <param name="beginTime">The start time</param>
        /// <param name="dateToCheck">Date to examine</param>
        /// <param name="timeToCheck">Time to examine</param>
        /// <returns>Whether the date is before range</returns>
        public static bool IsBeforeRange(DateAndTime beginDateAndTime, DateAndTime incomingDateAndTime)
        {
            DateTime begin = ConvertDateAndTime_DateTime(beginDateAndTime);
            DateTime curr = ConvertDateAndTime_DateTime(incomingDateAndTime);

            bool beginMatchRange = curr < begin;

            return beginMatchRange;
        }

        /// <summary>
        /// Checks if date is after range
        /// </summary>
        /// <param name="dateToCheck">Date to examine</param>
        /// <param name="timeToCheck">Time to examine</param>
        /// <param name="endDate">The end date</param>
        /// <param name="endTime">The end time</param>
        /// <returns>Whether the date is after range</returns>
        public static bool IsAfterRange(DateAndTime incomingDateAndTime, DateAndTime endDateAndTime)
        {
            DateTime end = ConvertDateAndTime_DateTime(endDateAndTime);
            DateTime curr = ConvertDateAndTime_DateTime(incomingDateAndTime);

            bool beginMatchRange = curr > end;

            return beginMatchRange;
        }

        #endregion Comparisons

        #region Operations

        /// <summary>
        /// Calculates the difference between dates
        /// </summary>
        /// <param name="start">Start date and time</param>
        /// <param name="event">Event dates and times</param>
        /// <param name="end">End date and time</param>
        /// <returns>The time difference and relative timeline location</returns>
        public static (TimeSpan TimeDiff, DateCompare Comparison) ComputeDiff(DateAndTime start, (DateAndTime startDateTime, DateAndTime endDateTime) @event, DateAndTime end)
        {
            bool EventStart_Before_Start = IsBeforeRange(start, @event.startDateTime);
            bool EventStart_Between_Start_End = IsWithinRange(start, @event.startDateTime, end);

            bool EventEnd_Before_Start = IsBeforeRange(start, @event.endDateTime);
            bool EventEnd_After_End = IsAfterRange(@event.endDateTime, end);
            bool EventEnd_Between_Start_End = IsWithinRange(start, @event.endDateTime, end);

            DateTime startDate = ConvertDateAndTime_DateTime(start);
            DateTime eventStart = ConvertDateAndTime_DateTime(@event.startDateTime);
            DateTime eventEnd = ConvertDateAndTime_DateTime(@event.endDateTime);

            TimeSpan span = new TimeSpan();
            DateCompare template = DateCompare.None;

            if (EventStart_Between_Start_End)
            {
                span = eventStart.Subtract(startDate);
                template = DateCompare.Before;
            }
            else if (EventStart_Before_Start && (EventEnd_Between_Start_End || EventEnd_After_End))
            {
                span = eventEnd.Subtract(startDate);
                template = DateCompare.During;
            }
            else if (EventStart_Before_Start && EventEnd_Before_Start)
            {
                span = startDate.Subtract(eventEnd);
                template = DateCompare.After;
            }

            return (TimeDiff: span, Comparison: template);
        }

        /// <summary>
        /// Calculates differences between dates
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="curr">The current date</param>
        /// <param name="end">The end date</param>
        /// <returns>Time difference and relative time location</returns>
        public static (TimeSpan TimeDiff, DateCompare Comparison) ComputeDiff(DateAndTime start, DateAndTime curr, DateAndTime end)
        {
            bool EventStart_Before_Start = IsBeforeRange(start, curr);
            bool EventStart_Between_Start_End = IsWithinRange(start, curr, end);

            bool EventEnd_Before_Start = IsBeforeRange(start, curr);
            bool EventEnd_After_End = IsAfterRange(curr, end);
            bool EventEnd_Between_Start_End = IsWithinRange(start, curr, end);

            DateTime startDate = ConvertDateAndTime_DateTime(start);
            DateTime eventStart = ConvertDateAndTime_DateTime(curr);
            DateTime eventEnd = ConvertDateAndTime_DateTime(curr);

            TimeSpan span = new TimeSpan();
            DateCompare template = DateCompare.None;

            if (EventStart_Between_Start_End)
            {
                span = eventStart.Subtract(startDate);
                template = DateCompare.Before;
            }
            else if (EventStart_Before_Start && (EventEnd_Between_Start_End || EventEnd_After_End))
            {
                span = eventEnd.Subtract(startDate);
                template = DateCompare.During;
            }
            else if (EventStart_Before_Start && EventEnd_Before_Start)
            {
                span = startDate.Subtract(eventEnd);
                template = DateCompare.After;
            }

            return (TimeDiff: span, Comparison: template);
        }

        public static (TimeSpan TimeDiff, DateCompare Comparison) ComputeDiff(DateAndTime startDateAndTime, DateAndTime endDateAndTime)
        {
            DateTime start = ConvertDateAndTime_DateTime(startDateAndTime);
            DateTime end = ConvertDateAndTime_DateTime(endDateAndTime);

            TimeSpan span = end.Subtract(start);
            DateCompare template = DateCompare.After;

            return (TimeDiff: span, Comparison: template);
        }

        #endregion Operations
    }
}
