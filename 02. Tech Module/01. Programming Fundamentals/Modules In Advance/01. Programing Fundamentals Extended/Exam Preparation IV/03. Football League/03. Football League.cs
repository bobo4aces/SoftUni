using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            Dictionary<string, int> standingsTable = new Dictionary<string, int>();
            Dictionary<string, int> scoringTable = new Dictionary<string, int>();
            while (input != "final")
            {
                //how to make key work?
                Regex regex = new Regex($"(.+|)(?<key1>{key})(?<homeTeam>[A-Za-z]+)(?<key2>{key}).+(?<key3>{key})(?<awayTeam>[A-Za-z]+)(?<key4>{key}).+(?<homeTeamScore>[0-9]+)\\:(?<awayTeamScore>[0-9]+)");
                Match teamsWithScores = regex.Match(input);
                StringBuilder homeTeamSb = new StringBuilder();
                StringBuilder awayTeamSb = new StringBuilder();
                string homeTeamGroup = teamsWithScores.Groups["homeTeam"].ToString().ToUpper();
                string awayTeamGroup = teamsWithScores.Groups["awayTeam"].ToString().ToUpper();
                int homeTeamScore = int.Parse(teamsWithScores.Groups["homeTeamScore"].ToString());
                int awayTeamScore = int.Parse(teamsWithScores.Groups["awayTeamScore"].ToString());
                foreach (var character in homeTeamGroup)
                {
                    homeTeamSb.Append(character);
                }
                foreach (var character in awayTeamGroup)
                {
                    awayTeamSb.Append(character);
                }
                string homeTeam = homeTeamSb.ToString();
                string awayTeam = awayTeamSb.ToString();
                if (!scoringTable.ContainsKey(homeTeam))
                {
                    scoringTable.Add(homeTeam, 0);
                }
                scoringTable[homeTeam] += homeTeamScore;
                if (!scoringTable.ContainsKey(awayTeam))
                {
                    scoringTable.Add(awayTeam, 0);
                }
                scoringTable[awayTeam] += awayTeamScore;
                bool isHomeWin = homeTeamScore > awayTeamScore ? true : false;
                bool isTie = homeTeamScore == awayTeamScore ? true : false;
                if (!standingsTable.ContainsKey(homeTeam))
                {
                    standingsTable.Add(homeTeam, 0);
                }
                if (!standingsTable.ContainsKey(awayTeam))
                {
                    standingsTable.Add(awayTeam, 0);
                }
                if (isTie)
                {
                    standingsTable[homeTeam] += 1;
                    standingsTable[awayTeam] += 1;
                }
                else if (isHomeWin)
                {
                    standingsTable[homeTeam] += 3;
                }
                else
                {
                    standingsTable[awayTeam] += 3;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            foreach (var team in standingsTable.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                int place = 1;
                Console.WriteLine($"{place++}. {team.Key} {team.Value}");
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in scoringTable.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                int counter = 0;
                if (counter++ != 3)
                {
                    Console.WriteLine($"- {team.Key} -> {team.Value}");
                }
            }
        }
    }
}
