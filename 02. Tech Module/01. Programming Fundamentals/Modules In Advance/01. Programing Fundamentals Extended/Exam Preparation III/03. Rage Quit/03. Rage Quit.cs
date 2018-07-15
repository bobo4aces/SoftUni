using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            List<string> counter = new List<string>();
            List<char> numbers = new List<char>() {  '0','1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Dictionary<string, int> wordsAndRepeat = new Dictionary<string, int>();
            string currentWord = "";
            string currentNumber = "";
            foreach (var character in input)
            {

                if (!numbers.Contains(character))
                {
                    if (currentWord != "" && currentNumber != "")
                    {
                        wordsAndRepeat.Add(currentWord, int.Parse(currentNumber));
                        currentWord = "";
                        currentNumber = "";
                    }
                    currentWord += character;
                    if (!counter.Contains(character.ToString().ToUpper()))
                    {
                        counter.Add(character.ToString().ToUpper());
                    }
                }
                else
                {
                    currentNumber += character.ToString();
                }
            }
            if (currentWord != "" && currentNumber != "")
            {
                wordsAndRepeat.Add(currentWord, int.Parse(currentNumber));
                currentWord = "";
                currentNumber = "";
            }
            Console.WriteLine($"Unique symbols used: {counter.Count()}");
            foreach (var word in wordsAndRepeat)
            {
                for (int i = 0; i < word.Value; i++)
                {
                    Console.Write(word.Key.ToUpper());
                }
            }
            Console.WriteLine();
        }
    }
}
