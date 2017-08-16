using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayOps
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            string tuesday = daysOfWeek[1];
            Console.WriteLine(tuesday);
        }
    }
}
