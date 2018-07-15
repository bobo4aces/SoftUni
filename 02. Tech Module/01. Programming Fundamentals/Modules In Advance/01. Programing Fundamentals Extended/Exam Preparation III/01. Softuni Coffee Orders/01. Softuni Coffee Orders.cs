using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                long daysInMonth = DateTime.DaysInMonth(orderDate.Year,orderDate.Month);
                decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
//10:14-10:33
//00:19