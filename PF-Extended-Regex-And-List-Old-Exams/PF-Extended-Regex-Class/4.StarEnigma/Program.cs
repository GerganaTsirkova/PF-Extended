using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var attackedPlanets = new List<string>();
            var destryedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string message = ReturningMessage(input);
                string inputPattern = @"([^\-!:@>]*)@([A-Za-z]+)([^\-!:@>]*):([0-9]+)([^\-!:@>]*)!(A|D)!([^\-!:@>]*)->([0-9]+)([^\-!:@>]*)";
                Match matchMessage = Regex.Match(message, inputPattern);
                if(!matchMessage.Success)
                {
                    continue;
                }
                else
                {
                    string name = matchMessage.Groups[2].Value.ToString();
                    string attakType = matchMessage.Groups[6].Value.ToString();
                    if (attakType == "A")
                    {
                        attackedPlanets.Add(name);
                    }
                    else if (attakType == "D")
                    {
                        destryedPlanets.Add(name);
                    }
                }
            }
            attackedPlanets.Sort();
            destryedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            for (int i = 0; i < attackedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {attackedPlanets[i]}");
            }
            Console.WriteLine($"Destroyed planets: {destryedPlanets.Count}");
            for (int i = 0; i < destryedPlanets.Count; i++)
            {
                Console.WriteLine($"-> {destryedPlanets[i]}");
            }
        }

        static string ReturningMessage(string input)
        {
            int counter = 0;
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] == 'S') || (arr[i] == 'T') || (arr[i] == 'A') || (arr[i] == 'R') || (arr[i] == 's') || (arr[i] == 't') || (arr[i] == 'a') || (arr[i] == 'r'))
                {
                    counter++;
                }
            }
            char[] result = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                char res = Convert.ToChar((int)arr[i] - counter);
                result[i] = res;
            }
            return new string(result);
        }
    }
}

