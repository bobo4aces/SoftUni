﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] arguments = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bomb = arguments[0];
            int range = arguments[1];

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == bomb)
                {
                    if (range <= i)
                    {
                        for (int j = i; j >= i - range; j--)
                        {
                            inputList[j] = 0;
                        }
                    }
                    if (range > i)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            inputList[j] = 0;
                        }
                    }

                    if (range + i >= inputList.Count - 1)
                    {
                        for (int j = i; j < inputList.Count; j++)
                        {
                            inputList[j] = 0;
                        }
                    }

                    if (range + i < inputList.Count - 1)
                    {
                        for (int j = i; j <= range + i; j++)
                        {
                            inputList[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(inputList.Sum());
        }
    }
}
