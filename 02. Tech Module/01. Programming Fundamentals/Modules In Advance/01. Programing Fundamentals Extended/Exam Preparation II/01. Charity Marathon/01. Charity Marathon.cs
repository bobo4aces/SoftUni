using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            long averageLapsPerRunner = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyDonatedPerKilometer = decimal.Parse(Console.ReadLine());
            long maximumRunners = trackCapacity * days;
            if (maximumRunners < runnersCount)
            {
                runnersCount = maximumRunners;
            }
            decimal totalLength = runnersCount * averageLapsPerRunner * trackLength / 1000;
            decimal money = totalLength * moneyDonatedPerKilometer;
            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
//17:49-18:11
//00:22