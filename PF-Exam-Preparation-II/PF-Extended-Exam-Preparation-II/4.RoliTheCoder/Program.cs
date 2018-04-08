using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictAgenda = new Dictionary<int, string>();
            var dictParticipants = new Dictionary<string, List<string>>();
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Time for Code")
                {
                    break;
                }
                if(IsValid(input))
                {
                    string[] tokens = input.Split().ToArray();
                    int number = int.Parse(tokens[0]);
                    string eventt = tokens[1].TrimStart('#');
                    List<string> participants = new List<string>();
                    if(tokens.Length>=3)
                    {
                        for (int i = 2; i < tokens.Length; i++)
                        {
                            participants.Add(tokens[i]);
                        }
                    }
                    List<string> people = participants.Distinct().ToList();
                    if (!dictAgenda.ContainsKey(number))
                    {
                        dictAgenda.Add(number, eventt);
                        if(!dictParticipants.ContainsKey(eventt))
                        {
                            dictParticipants.Add(eventt, people);
                        }
                    }
                    else if(dictAgenda.ContainsKey(number))
                    {
                        if((dictAgenda[number]==eventt)&&(dictParticipants.ContainsKey(eventt)))
                        {
                            for (int i = 0; i < people.Count; i++)
                            {
                                if (!dictParticipants[eventt].Contains(people[i]))
                                {
                                    dictParticipants[eventt].Add(people[i]);
                                }
                            }
                            
                        }
                    }
                }
                
            }
            foreach (var arrangedEvent in dictParticipants.OrderByDescending(x=>x.Value.Count).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"{arrangedEvent.Key} - {arrangedEvent.Value.Count}");
                foreach (var person in arrangedEvent.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"{person}");
                }
            }
        }

        static bool IsValid(string input)
        {
            string pattern = @"[0-9]+\s#[A-Za-z0-9]+(\s@[A-Za-z0-9]+)*";
            var match = Regex.Match(input, pattern);
            if(match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
