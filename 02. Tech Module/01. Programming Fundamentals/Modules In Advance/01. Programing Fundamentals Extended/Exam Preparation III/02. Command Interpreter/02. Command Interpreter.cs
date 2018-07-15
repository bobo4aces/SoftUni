using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> result = new List<string>();
            while (input[0] != "end")
            {
                if (input[0] == "reverse" && input[1] == "from" && input[3] == "count")
                {
                    
                }
                else if (input[0] == "sort" && input[1] == "from" && input[3] == "count")
                {
                    //TO DO
                }
                else if (input[0] == "rollLeft" && input[2] == "times")
                {
                    //TO DO
                }
                else if (input[0] == "rollRight" && input[2] == "times")
                {
                    //TO DO
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
//10:33-