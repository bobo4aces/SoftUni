using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> driversNames = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<decimal> zones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();
            List<long> checkpointIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            foreach (var driver in driversNames)
            {
                decimal fuel = driver[0];
                bool isFinish = true;
                int indexOfFinish = 0;
                foreach (var zone in zones)
                {
                    if (checkpointIndexes.Contains(zones.IndexOf(zone)))
                    {
                        fuel += zone;
                    }
                    else
                    {
                        fuel -= zone;
                    }
                    if (fuel<=0)
                    {
                        isFinish = false;
                        indexOfFinish = zones.IndexOf(zone);
                        break;
                    }
                }
                if (isFinish)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {indexOfFinish}");
                }
            }
        }
    }
}
//14:40-15:17
//00:37
