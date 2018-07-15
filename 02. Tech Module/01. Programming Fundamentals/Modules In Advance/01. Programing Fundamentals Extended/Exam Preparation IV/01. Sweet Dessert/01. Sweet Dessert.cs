using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestsCount = int.Parse(Console.ReadLine());
            decimal bananasSinglePrice = decimal.Parse(Console.ReadLine());
            decimal eggsSinglePrice = decimal.Parse(Console.ReadLine());
            decimal berriesKiloPrice = decimal.Parse(Console.ReadLine());
            decimal priceForPortion = 2 * bananasSinglePrice + 4 * eggsSinglePrice + (berriesKiloPrice / 5);
            int portions = guestsCount / 6;
            if (guestsCount%6!=0)
            {
                portions++;
            }
            decimal totalAmount = portions * priceForPortion;
            if (cash>=totalAmount)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalAmount:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalAmount- cash):f2}lv more.");
            }
            
        }
    }
}
