using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Task___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < messagesCount; i++)
            {
                string message = Console.ReadLine();
                int decriptionKey = 0;
                string decriptionKeyPattern = "S|s|T|t|A|a|R|r";
                Regex decriptionKeyRegex = new Regex(decriptionKeyPattern);
                MatchCollection decriptionKeyMatches = decriptionKeyRegex.Matches(message);
                char[] removeArr = new char[] { 'S', 's', 'T', 't', 'A', 'a', 'R', 'r' };
                string newMessage = "";
                for (int j = 0; j < message.Length; j++)
                {
                    if (!removeArr.Contains(message[j]))
                    {
                        newMessage += message[j];
                    }
                    else
                    {
                        decriptionKey++;
                        newMessage += message[j];
                    }
                }
                
                StringBuilder sb = new StringBuilder();
                string decriptedMessage = "";
                for (int j = 0; j < newMessage.Length; j++)
                {
                    decriptedMessage += (char)(newMessage[j]-decriptionKey);
                }
                string newPattern = @"(@(?<planetName>[A-Za-z]+)?|:(?<planetPopulation>\d+)?|!(?<attackType>A|D)!?|->(?<soldierCount>\d+))";
                Regex newRegex = new Regex(newPattern);
                Match newMatch = newRegex.Match(decriptedMessage);
                string attackType = "";
                string planetName = "";
                if (newRegex.IsMatch(decriptedMessage))
                {
                    planetName = newMatch.Groups["planetName"].ToString();
                    attackType = newMatch.Groups["attackType"].ToString();
                    if (attackType=="A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
               
                

            }
            Console.WriteLine($"Attacked planets: { attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(a=>a))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(a => a))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }
    }
}
