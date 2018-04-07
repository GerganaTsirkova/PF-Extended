using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SoftuniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var karaokeData = new Dictionary<string, Dictionary<string, List<string>>>();
            List<string> participants = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> songs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();
            while (input != "dawn")
            {
                string[] tokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];
                if ((participants.Contains(participant)) && (songs.Contains(song)))
                {
                    if (!karaokeData.ContainsKey(participant))
                    {
                        var inner = new Dictionary<string, List<string>>();
                        var innerList = new List<string>();
                        innerList.Add(award);
                        inner.Add(song, innerList);
                        karaokeData.Add(participant, inner);
                    }
                    else
                    {
                        if (!karaokeData[participant].ContainsKey(song))
                        {
                            var innerList = new List<string>();
                            innerList.Add(award);
                            karaokeData[participant].Add(song, innerList);
                        }
                        else
                        {
                            if (!karaokeData[participant][song].Contains(award))
                            {
                                karaokeData[participant][song].Add(award);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            if (karaokeData.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var singer in karaokeData.OrderByDescending(x => karaokeData[x.Key].Values.First().Count).ThenBy(y => y.Key))
                {
                    Console.Write($"{singer.Key}: ");
                    foreach (var song in singer.Value)
                    {
                        Console.WriteLine($"{song.Value.Count} awards");
                        foreach (var award in song.Value.OrderBy(x => x))
                        {
                            Console.WriteLine($"--{award}");
                        }

                    }
                }
            }
        }
    }
}
