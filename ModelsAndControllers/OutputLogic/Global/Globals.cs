using System;

namespace Backend.OutputLogic.Global
{
    public struct TimeAndDateGlobals
    {
        public static string GetMonthName(int month)
        {
            switch(month)
            {
                case (int) Months.January: return "January";
                case (int) Months.February: return "February";
                case (int) Months.March: return "March";
                case (int) Months.April: return "April";
                case (int) Months.May: return "May";
                case (int) Months.June: return "June";
                case (int) Months.July: return "July";
                case (int) Months.August: return "August";
                case (int) Months.September: return "September";
                case (int) Months.October: return "October";
                case (int) Months.November: return "November";
                case (int) Months.December: return "December";
                default: return "";
            }
        }

        public static string GetDayOfTheWeek(int dow)
        {
            switch (dow)
            {
                case (int)DayOfTheWeek.Sun: return "Sunday";
                case (int)DayOfTheWeek.Mon: return "Monday";
                case (int)DayOfTheWeek.Wed: return "Wednesday";
                case (int)DayOfTheWeek.Thur: return "Thursday";
                case (int)DayOfTheWeek.Fri: return "Friday";
                case (int)DayOfTheWeek.Sat: return "Saturday";
                default: return "";
            }
        }
    }

    public enum Months
    {
        None, January, February, March, April, May, June, July, August, September, October, November, December
    }

    public enum ControlType
    {
        None, Label, Forms, TextArea, RichTextArea, IconNotifier, DatePicker, Calendar, ListBox
    }

    public enum CrudPurpose
    {
        None, Create, Edit, Error
    }

    public enum TimeOfDay
    {
        AM, PM
    }

    public enum DayOfTheWeek
    {
        Sun, Mon, Tues, Wed, Thur, Fri, Sat
    }

    public struct Ids
    {
        public static Guid CreateId()
        {
            return Guid.NewGuid();
        }
    }
}
