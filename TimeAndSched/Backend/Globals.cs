using System;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Backend.Globals
{
    public struct DateGlobals
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

    public struct ControlGlobals
    {
        public static Guid CreateId()
        {
            return Guid.NewGuid();
        }
    }
    
    public class TimeGlobals
    {
        public static Time GetCurrTime { get { return new Time(true); } }
        public static Date GetCurrDate { get { return new Date(true); } }
    }
}
