using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsDate
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public short Year { get; set; }

        public string Time { get; set; }

        public clsDate()
        {
            this.Day = "";
            this.Month = "";
            this.Year = 0;
            this.Time = "";
        }

        public clsDate(string Day, string Month, short Year, string Time)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            this.Time = Time;
        }

        public static clsDate GetSystemDate()
        {
            // جعل أسماء الأيام والأشهر باللغة الإنجليزية حتى لو نظام التشغيل عربي.
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime Date = DateTime.Now;

            string Day = Date.ToString("dddd", enUS);
            string Month = Date.ToString("MMMM", enUS);
            short Year = (short)Date.Year;
            string Time = Date.ToString("hh:mm:ss tt", enUS);

            return new clsDate(Day, Month, Year, Time);
        }

        public static string DateToString(clsDate Date)
        {
            return Date.Day + "," + Date.Month + " " + Date.Year.ToString() + "\n" + Date.Time;
        }
    }
}
