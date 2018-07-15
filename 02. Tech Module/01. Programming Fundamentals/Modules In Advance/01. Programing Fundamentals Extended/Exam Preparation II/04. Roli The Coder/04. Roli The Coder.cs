using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    public class Events
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public List<string> Participants { get; set; }

        //public Events(int id, string name)
        //{
        //    Id = id;
        //    EventName = name;
        //    Participants = new List<string>();
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Events events = new Events();
            while (input!= "Time for Code")
            {
                if (!input.Contains('#'))
                {
                    break;
                }
                string[] info = input.Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries).Select(i => i.Trim()).ToArray();
                int id = int.Parse(info[0]);
                string[] eventInfo = info[1].Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries).Select(e => e.Trim()).ToArray();
                string @event = eventInfo[0].Trim();
                string[] participants = eventInfo.Skip(1).Select(p=>p.Trim()).ToArray();
                if (events.Id==id)
                {
                    if (events.EventName==@event)
                    {
                        events.Participants.AddRange(participants);
                    }
                }
                else
                {
                    if (@event!=null)
                    {
                        events.Id = id;
                        events.EventName = @event;
                        events.Participants = new List<string>();
                        events.Participants.AddRange(participants);
                    }
                    
                    
                }
                
                input = Console.ReadLine();
            }
            foreach (var count in events.Participants.OrderByDescending(p => p.Count()).ThenBy(p => p))
            {
                Console.WriteLine($"{events.EventName} - {events.Participants.Count()}");
                foreach (var participant in events.Participants.OrderByDescending(p=>p))
                {
                    Console.WriteLine($"@{participant}");
                }
            }
        }
    }
}
