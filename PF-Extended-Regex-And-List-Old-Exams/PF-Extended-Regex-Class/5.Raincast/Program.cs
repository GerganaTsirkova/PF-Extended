using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _5.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> type = new List<string>();
            List<string> source = new List<string>();
            List<string> forecast = new List<string>();
            bool typeBool = false;
            bool sorceBool = false;
            bool forecastBool = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Davai Emo")
                {
                    break;
                }
                string patternType = @"^Type: (Normal|Warning|Danger)$";
                Match matchtype = Regex.Match(input, patternType);
                if((!matchtype.Success)&&(type.Count==forecast.Count)&&(forecast.Count==source.Count))
                {
                    continue;
                }
                else if((matchtype.Success)&&((type.Count==source.Count)&&(source.Count==forecast.Count)))
                {
                    if((matchtype.Groups[1].Value=="Normal")||(matchtype.Groups[1].Value == "Warning")||(matchtype.Groups[1].Value == "Danger"))
                    {
                        typeBool = true;
                        type.Add(matchtype.Groups[1].Value.ToString());
                        continue;
                    }
                     else
                    {
                        continue;
                    }
                }
                string patternSource = @"^Source: ([a-zA-Z0-9]+)$";
                Match sourceMatch = Regex.Match(input, patternSource);
                if((!sourceMatch.Success)&&(type.Count-1 == forecast.Count) && (forecast.Count == source.Count))
                {
                    continue;
                }
                else if((sourceMatch.Success)&&((typeBool==true)&&(type.Count-1==source.Count)&&(type.Count-1==forecast.Count)))
                {
                    sorceBool = true;
                    source.Add(sourceMatch.Groups[1].Value.ToString());
                    continue;
                }
                string patternForecast = @"^Forecast: ([^!.,?]+)$";
                Match matchForecast = Regex.Match(input, patternForecast);
                if(!matchForecast.Success)
                {
                    continue;
                }
                else if((matchForecast.Success)&&(source.Count-1==forecast.Count)&&(type.Count-1==forecast.Count)&&(sorceBool==true)&&(typeBool==true))
                {
                    forecastBool = true;
                    forecast.Add(matchForecast.Groups[1].Value.ToString());
                }
                if((forecastBool)&&(sorceBool)&&(typeBool))
                {
                    forecastBool = false;
                    sorceBool = false;
                    typeBool = false;
                }
            }
            if((source.Count==forecast.Count)&&(forecast.Count==type.Count))
            {
                for (int i = 0; i < type.Count; i++)
                {
                    Console.WriteLine($"({type[i]}) {forecast[i]} ~ {source[i]}");
                }
            }
            else
            {
                int minimum = Math.Min(type.Count, forecast.Count);
                int min = Math.Min(minimum, source.Count);
                for (int i = 0; i < min; i++)
                {
                    Console.WriteLine($"({type[i]}) {forecast[i]} ~ {source[i]}");
                }
            }
        }
    }
}
