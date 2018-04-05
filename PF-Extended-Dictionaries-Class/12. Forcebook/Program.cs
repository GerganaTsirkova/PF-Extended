using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Forcebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forcesides = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                char[] arr = input.ToCharArray();
                if (arr.Contains('|'))
                {
                    string[] token = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = token[0];
                    string user = token[1];
                    if (!forcesides.ContainsKey(side))
                    {
                        if (!forcesides.Values.Any(x => x.Contains(user)))
                        {
                            var inner = new List<string>();
                            inner.Add(user);
                            forcesides.Add(side, inner);
                        }
                        else
                        {
                            foreach (var item in forcesides)
                            {
                                if (item.Value.Contains(user))
                                {
                                    item.Value.Remove(user);
                                    break;
                                }
                            }
                            var inner = new List<string>();
                            inner.Add(user);
                            forcesides.Add(side, inner);
                        }
                    }
                    else if (forcesides.ContainsKey(side))
                    {
                        if (!forcesides.Values.Any(x => x.Contains(user)))
                        {
                            forcesides[side].Add(user);
                        }
                        else if (forcesides.Values.Any(x => x.Contains(user)))
                        {
                            foreach (var item in forcesides)
                            {
                                if (item.Value.Contains(user))
                                {
                                    item.Value.Remove(user);
                                    break;
                                }
                            }
                            forcesides[side].Add(user);
                        }
                    }
                }
                else if (arr.Contains('>') && (arr.Contains('-')))
                {
                    string[] token = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string user = token[0];
                    string side = token[1];
                    int counter = 0;
                    if (forcesides.ContainsKey(side))
                    {
                        foreach (var item in forcesides)
                        {
                            if (item.Value.Contains(user))
                            {
                                forcesides[side].Add(user);
                                forcesides[item.Key].Remove(user);
                                Console.WriteLine($"{user} joins the {side} side!");
                                counter++;
                                break;
                            }
                        }
                        if ((counter == 0) && (forcesides.ContainsKey(side)))
                        {
                            forcesides[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                    else if (!forcesides.ContainsKey(side))
                    {
                        foreach (var item in forcesides)
                        {
                            if (item.Value.Contains(user))
                            {
                                var inner = new List<string>();
                                inner.Add(user);
                                forcesides[item.Key].Remove(user);
                                forcesides.Add(side, inner);
                                Console.WriteLine($"{user} joins the {side} side!");
                                counter++;
                                break;
                            }
                        }
                        if (counter == 0)
                        {
                            var inner = new List<string>();
                            inner.Add(user);
                            forcesides.Add(side, inner);
                            Console.WriteLine($"{user} joins the {side} side!");
                        }
                    }
                }

                input = Console.ReadLine();
            }
            if (forcesides.Count > 0)
            {
                foreach (var item in forcesides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    if (item.Value.Count > 0)
                    {
                        Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                        foreach (var i in item.Value.OrderBy(x => x))
                        {
                            Console.WriteLine($"! {i}");
                        }
                    }

                }
            }
        }
    }
}
