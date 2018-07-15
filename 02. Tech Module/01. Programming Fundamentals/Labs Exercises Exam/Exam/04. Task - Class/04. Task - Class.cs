using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Task___Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
            while (input!= "Lumpawaroo")
            {
                string[] info = input
                    .Split(new char[] { '|', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string forceSide = "";
                string forceUser = "";  
                if (input.Contains('|'))
                {
                    forceSide = info[0].Trim();
                    forceUser = info[1].Trim();
                    if (!forces.ContainsKey(forceSide))
                    {
                        List<string> forcelist = new List<string>();
                        forces.Add(forceSide, forcelist);
                        forces[forceSide].Add(forceUser);
                    }
                    else
                    {
                        forces[forceSide].Add(forceUser);
                    }
                
                }
                if (input.Contains("->"))
                {
                    forceSide = info[1].Trim();
                    forceUser = info[0].Trim();
                    foreach (var users in forces.Values)
                    {
                        if (users.Contains(forceUser))
                        {
                            users.Remove(forceUser);
                            forces[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }
                    if (!forces.ContainsKey(forceSide))
                    {
                        List<string> forcelist = new List<string>();
                        forces.Add(forceSide, forcelist);
                    }
                    if (!forces[forceSide].Contains(forceUser))
                    {
                        forces[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        forces[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                
                }
                input = Console.ReadLine();
            }
            foreach (var force in forces.OrderByDescending(k=>k.Value.Count).ThenBy(k=>k.Key))
            {
                if (force.Value.Count!=0)
                {
                    Console.WriteLine($"Side: {force.Key}, Members: {force.Value.Count}");
                    foreach (var user in force.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
                
            }
        }
    }
}
