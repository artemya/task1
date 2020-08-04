using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        public struct DateRange
        {
            public DateTime start;
            public DateTime end;
        }
        static void Main(string[] args)
        {
            var start = new DateTime(2020, 5, 1);
            var end = new DateTime(2020, 5, 25);
            
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2020, 5, 2),
                new DateTime(2020, 5, 9),
                new DateTime(2020, 5, 20),
                new DateTime(2020, 5, 13),
                new DateTime(2020, 5, 1),
            };
            Console.WriteLine(CountWorkingDays(start, end, holidays));

            DateRange date = new DateRange();
            date.start = start;
            date.end = end;
            Console.WriteLine(CountWorkingDays(date.start, date.end, holidays));
        }


        public static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            List<DateTime> workDates = new List<DateTime>();
            for (DateTime date = start; date <= end; date = date.AddDays(1)) {
                workDates.Add(date);
            }
            int sum = 0;
            DateTime[] dateRange = workDates.ToArray();
            foreach(DateTime date in dateRange) {
                if(!Array.Exists(holidays, holidayDay => holidayDay == date))
                {
                    sum += 1;
                }
            }
            return sum; 
        }
            public static int CountWorkingDays(DateRange range, DateTime[] holidays)
            {
                return CountWorkingDays(range.start, range.end, holidays);
            }

    }
}
