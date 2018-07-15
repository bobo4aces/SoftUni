using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new[] { ',',' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string pattern = @"(\@{6,10}|\#{6,10}|\${6,10}|\^{6,10})(.*?)(\@{6,10}|\#{6,10}|\${6,10}|\^{6,10})";
                    string qualifier = @"(\@|\#|\$|\^){6,10}(.*?)(\@|\#|\$|\^){6,10}";
                    Regex regex = new Regex(pattern);
                    Regex qualifierRegex = new Regex(qualifier);
                    var matches = regex.Matches(ticket);
                    var qualifiermatches = qualifierRegex.Matches(ticket);
                    if (Regex.IsMatch(ticket, qualifier))
                    {
                        foreach (Match match in matches)
                        {
                            int minLength = Math.Min(match.Groups[1].Length, match.Groups[3].Length);
                            if (match.Groups[1].Value[0] == match.Groups[3].Value[0]&&minLength>=6)
                            {
                                if (6<=minLength&&minLength<=9)
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {minLength}{ match.Groups[1].Value[0]}");
                                }
                                else if (minLength==10)
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {minLength}{ match.Groups[1].Value[0]} Jackpot!");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - no match");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
//15:22-15:29
//15:44-17:11
//01:27
//02:33
//04:00