using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participantsList = Console.ReadLine()
                .Split(new char[] {',' },StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Trim())
                .ToList();
            List<string> songsList = Console.ReadLine()
                .Split(new char[] {',' },StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            string[] command = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            Dictionary<string, List<string>> participantsWithSongs = new Dictionary<string, List<string>>();
            while (command[0]!= "dawn")
            {
                string name = command[0];
                string song = command[1];
                string award = command[2];

                if (participantsList.Contains(name)&&songsList.Contains(song))
                {
                    if (!participantsWithSongs.ContainsKey(name))
                    {
                        participantsWithSongs.Add(name, new List<string>());
                    }
                    if (!participantsWithSongs[name].Contains(award))
                    {
                        participantsWithSongs[name].Add(award);
                    } 
                }
                command = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            }
            foreach (var participant in participantsWithSongs.OrderByDescending(a=>a.Value.Count()).ThenBy(p=>p.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count()} awards");
                foreach (var song in participant.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"--{song}");
                }
            }
            if (participantsWithSongs.Count==0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
//13:44-14:26
//00:42