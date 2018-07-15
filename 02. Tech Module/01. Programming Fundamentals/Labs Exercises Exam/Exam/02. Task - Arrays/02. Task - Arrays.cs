using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            int sum = 1;
            int bestSum = 0;
            int bestTotalSum = 0;
            int[] array = new int[length];
            int[] resultArray = new int[length];
            bool issss = false;
            while (input != "Clone them!")
            {
                array = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                for (int i = 1; i <= array.Length - 1; i++)
                {
                    if (array[i] == array[start]&&array[i]==1)
                    {
                        len++;
                        sum++;
                    }
                    else
                    {
                        start = i;
                        len = 1;
                    }
                    if (bestLen <= len)
                    {
                        if (bestLen!=len)
                        {
                            bestSum = sum;
                            bestTotalSum = array.Sum();
                            bestStart = start;
                            bestLen = len;
                            resultArray = array;
                        }
                        else
                        {
                            if (bestStart!=start)
                            {
                                if (bestStart > start)
                                {
                                    bestStart = start;
                                    resultArray = array;
                                }
                            }
                            else
                            {
                                if (array.Sum() > resultArray.Sum())
                                {
                                    bestSum = array.Sum();
                                    resultArray = array;
                                }
                                else
                                {
                                    bestSum = resultArray.Sum();  
                                }
                            }
                            
                        }
                        
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestStart + 1} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
