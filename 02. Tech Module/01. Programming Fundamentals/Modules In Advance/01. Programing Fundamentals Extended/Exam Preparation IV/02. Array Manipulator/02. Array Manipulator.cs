using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index >= array.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        for (int i = 0; i < index; i++)
                        {
                            int lastDigit = array[array.Length - 1];
                            for (int j = array.Length - 1; j > 0; j--)
                            {
                                array[j-1] = array[j];
                            }
                            array[0] = lastDigit; 
                        }
                    }
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        int indexMax = 0;
                        bool isFound = false;
                        for (int i = 0; i < array.Length; i++)
                        {

                            if (array[i] % 2 == 0)
                            {
                                if (array[i] == array.Where(x => x % 2 == 0).Max(x => x))
                                {
                                    indexMax = i;
                                    isFound = true;
                                }
                            }
                        }
                        if (isFound)
                        {
                            Console.WriteLine(indexMax);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        int indexMax = 0;
                        bool isFound = false;
                        for (int i = 0; i < array.Length; i++)
                        {

                            if (array[i] % 2 !=0)
                            {
                                if (array[i] == array.Where(x => x % 2 !=0).Max(x => x))
                                {
                                    indexMax = i;
                                    isFound = true;
                                }
                            }
                        }
                        if (isFound)
                        {
                            Console.WriteLine(indexMax);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        int indexMin = 0;
                        bool isFound = false;
                        for (int i = 0; i < array.Length; i++)
                        {

                            if (array[i] % 2 == 0)
                            {
                                if (array[i] == array.Where(x => x % 2 == 0).Min(x => x))
                                {
                                    indexMin = i;
                                    isFound = true;
                                }
                            }
                        }
                        if (isFound)
                        {
                            Console.WriteLine(indexMin);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        int indexMin = 0;
                        bool isFound = false;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 !=0)
                            {
                                if (array[i] == array.Where(x => x % 2 !=0).Min(x => x))
                                {
                                    indexMin = i;
                                    isFound = true;
                                }
                            }
                        }
                        if (isFound)
                        {
                            Console.WriteLine(indexMin);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    if (count >= array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (command[2] == "even")
                    {
                        int counter = 0;
                        List<int> numbers = new List<int>();
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                if (count <= counter)
                                {
                                    numbers.Add(array[i]);
                                }
                                else
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    }
                    else if (command[2] == "odd")
                    {
                        int counter = 0;
                        List<int> numbers = new List<int>();
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 !=0)
                            {
                                if (count <= counter)
                                {
                                    numbers.Add(array[i]);
                                }
                                else
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count >= array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else if (command[2] == "even")
                    {
                        int counter = 0;
                        List<int> numbers = new List<int>();
                        for (int i = array.Length - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 == 0)
                            {
                                if (count <= counter)
                                {
                                    numbers.Add(array[i]);
                                }
                                else
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                        numbers.Reverse();
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    }
                    else if (command[2] == "odd")
                    {
                        int counter = 0;
                        List<int> numbers = new List<int>();
                        for (int i = array.Length - 1; i >= 0; i--)
                        {
                            if (array[i] % 2 !=0)
                            {
                                if (count <= counter)
                                {
                                    numbers.Add(array[i]);
                                }
                                else
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                        numbers.Reverse();
                        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}
