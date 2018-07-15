using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[] command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (i == indexes[j])
                    {
                        field[i] = 1;
                    }
                }

            }
            while (command[0] != "end")
            {
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                if ((0<=ladybugIndex && ladybugIndex <= field.Length - 1) && field[ladybugIndex] == 1)
                {
                    if (direction == "right")
                    {
                        field[ladybugIndex] = 0;
                        if (field.Length - 1 >= ladybugIndex + flyLength)
                        {
                            field[ladybugIndex + flyLength] = 1;
                        }
                    }
                    else if (direction == "left")
                    {
                        field[ladybugIndex] = 0;
                        if (0 <= ladybugIndex - flyLength)
                        {
                            field[ladybugIndex - flyLength] = 1;
                        }
                    }
                }
                command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(" ", field));

        }
    }
}
//18:13-18:56
//19:03-19:19
//00:59