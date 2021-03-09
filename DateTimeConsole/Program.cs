using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime Sample");

            //var utcNow = DateTime.UtcNow;
            //var tz = TimeZone.CurrentTimeZone;

            //Console.WriteLine(utcNow.ToString("o"));

            //Console.WriteLine(utcNow.ToLocalTime().ToString("o"));

            //Console.WriteLine($"{tz.StandardName}");

            var comparer = new DateTimeComparisons();

            comparer.Compare();

            Console.ReadKey();
        }
    }
}
