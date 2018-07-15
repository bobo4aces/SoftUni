using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss",CultureInfo.InvariantCulture);
            long stepsCount = long.Parse(Console.ReadLine());
            long secondsPerStep = long.Parse(Console.ReadLine());
            long totalSecondsForSteps = stepsCount * secondsPerStep;
            long seconds=totalSecondsForSteps % 60;
            long minutes = (totalSecondsForSteps/60)% 60;
            long hours = (totalSecondsForSteps/3600)% 24;
            TimeSpan time = TimeSpan.Parse($"{hours:d2}:{minutes:d2}:{seconds:d2}");
            DateTime arrivalTime = leavingTime.Add(time);
            Console.WriteLine($"Time Arrival: {arrivalTime.ToString("HH:mm:ss")}");
        }
    }
}
//12:07-12:16
//12:39-13:43
//01:14