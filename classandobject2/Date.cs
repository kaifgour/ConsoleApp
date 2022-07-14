using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject2
{
    internal class Date
    {
        public int Day { get; set; }
        public string Month { get; set; }

        public int Year { get; set; }

        public Date()
        {
            Day = 4;
            Month = "JULY";
            Year = 2022;
        }
        public Date(int day, string month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return Day+" "+Month+" "+Year;
        }
    }
}
