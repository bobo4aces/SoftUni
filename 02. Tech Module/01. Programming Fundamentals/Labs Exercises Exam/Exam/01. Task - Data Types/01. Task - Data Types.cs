using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task___Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyAmount = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsabreSinglePrice = decimal.Parse(Console.ReadLine());
            decimal robesSinglePrice = decimal.Parse(Console.ReadLine());
            decimal beltsSinglePrice = decimal.Parse(Console.ReadLine());
            int freeBelts = studentsCount / 6;
            int lightsabreCount = (int)Math.Ceiling(studentsCount * 1.1M);
            decimal price = lightsabreSinglePrice * lightsabreCount + robesSinglePrice * studentsCount + beltsSinglePrice * (studentsCount - freeBelts);
            if (price<= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(price-moneyAmount):f2}lv more.");
            }
        }
    }
}