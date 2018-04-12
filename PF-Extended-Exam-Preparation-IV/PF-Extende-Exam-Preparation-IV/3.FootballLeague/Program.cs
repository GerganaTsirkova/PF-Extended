using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            var dictPoints = new Dictionary<string,int>();
            var dictGoals = new Dictionary<string, int>();
            while(true)
            {
                string input = Console.ReadLine();
                if (input=="final")
                {
                    break;
                }
                string[] tokens = input.Split().ToArray();
                string firstTeam = tokens[0];
                string secondTeam = tokens[1];
                string nameFirstTeam = GetNameFirst(firstTeam,key).ToUpper();
                string nameSecondTeam = GetNameSecond(secondTeam,key).ToUpper();
                string[] result = tokens[2].Split(':').ToArray();
                int firstTeamScore = int.Parse(result[0]);
                int secondTeamScore = int.Parse(result[1]);
                FillDictionaryGoals(dictGoals, firstTeamScore, nameFirstTeam,secondTeamScore,nameSecondTeam);
                int pointsFirstTeam = GetFirstPoints(firstTeamScore,secondTeamScore);
                int pointsSecondTeam = GetSecondPoints(firstTeamScore,secondTeamScore);
                FillDictionaryPoints(dictPoints, pointsFirstTeam, nameFirstTeam, pointsSecondTeam, nameSecondTeam);
            }
            int counter = 0;
            if (dictPoints.Count > 0)
            {
                Console.WriteLine("League standings:");
                foreach (var team in dictPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {team.Key} {team.Value}");
                }
            }

            counter = 0;
            if (dictGoals.Count > 0)
            {
                Console.WriteLine("Top 3 scored goals:");
                foreach (var team in dictGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"- {team.Key} -> {team.Value}");
                    if (counter == 3)
                    {
                        break;
                    }
                }
            }
        }

        static void FillDictionaryPoints(Dictionary<string, int> dictPoints, int firstTeamScore, string nameFirstTeam, int secondTeamScore, string nameSecondTeam)
        {
            if (!dictPoints.ContainsKey(nameFirstTeam))
            {
                dictPoints.Add(nameFirstTeam, firstTeamScore);
            }
            else
            {
                dictPoints[nameFirstTeam] += firstTeamScore;
            }
            if (!dictPoints.ContainsKey(nameSecondTeam))
            {
                dictPoints.Add(nameSecondTeam, secondTeamScore);
            }
            else
            {
                dictPoints[nameSecondTeam] += secondTeamScore;
            }
            return;
        }

        static int GetSecondPoints(int firstTeamScore, int secondTeamScore)
        {
            int secondTeamPoints = 0;
            if (firstTeamScore == secondTeamScore)
            {
                secondTeamPoints++;
            }
            else if (firstTeamScore < secondTeamScore)
            {
                secondTeamPoints += 3;
            }
            return secondTeamPoints;
        }

        static int GetFirstPoints(int firstTeamScore, int secondTeamScore)
        {
            int firstTeamPoints = 0;
            if (firstTeamScore==secondTeamScore)
            {
                firstTeamPoints++;
            }
            else if(firstTeamScore>secondTeamScore)
            {
                firstTeamPoints += 3;
            }
            return firstTeamPoints;
        }

        static void FillDictionaryGoals(Dictionary<string, int> dictGoals, int firstTeamScore, string nameFirstTeam, int secondTeamScore, string nameSecondTeam)
        {
            if(!dictGoals.ContainsKey(nameFirstTeam))
            {
                dictGoals.Add(nameFirstTeam, firstTeamScore);
            }
            else
            {
                dictGoals[nameFirstTeam] += firstTeamScore;
            }
            if (!dictGoals.ContainsKey(nameSecondTeam))
            {
                dictGoals.Add(nameSecondTeam, secondTeamScore);
            }
            else
            {
                dictGoals[nameSecondTeam] += secondTeamScore;
            }
        }

        static string GetNameFirst(string firstTeam,string key)
        {
            int startIndex = firstTeam.IndexOf(key)+key.Length;
            string nameRaw = firstTeam.Substring(startIndex);
            int endIndex = nameRaw.IndexOf(key);
            string name = nameRaw.Substring(0, endIndex);
            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string GetNameSecond(string secondTeam, string key)
        {
            int startIndex = secondTeam.IndexOf(key) + key.Length;
            string nameRaw = secondTeam.Substring(startIndex);
            int endIndex = nameRaw.IndexOf(key);
            string name = nameRaw.Substring(0, endIndex);
            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
