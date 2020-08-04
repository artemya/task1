using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(2020, 5, 1);
            Console.WriteLine(start);
            var end = new DateTime(2020, 5, 24);
            Console.WriteLine(end);
            
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2020, 5, 2),
                new DateTime(2020, 5, 9),
                new DateTime(2020, 5, 20),
                new DateTime(2020, 5, 13),
                new DateTime(2020, 5, 1),


            };
            Console.WriteLine(CountWorkingDays(start, end, holidays));
        }


        public static int CountWorkingDays(DateTime start, DateTime end, DateTime[] holidays)
        {
            List<DateTime> workDates = new List<DateTime>();
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                workDates.Add(date);
            }
            DateTime[] dateRange = workDates.ToArray();
            return dateRange.Length - holidays.Length; 
        }
    }
}
