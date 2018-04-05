using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = false;
            bool second = false;
            bool third = false;
            string type = "";
            string forecast = "";
            string source = "";
            List<string> output = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Davai Emo")
                {
                    break;
                }
                if(first == false)
                {
                    if ((input == "Type: Normal")||(input == "Type: Danger")||(input == "Type: Warning"))
                    {
                        first = true;
                        string[] tokens = input.Split().ToArray();
                        type = tokens[1];
                        continue;
                    }
                }
                if((second==false)&&(first==true))
                {
                    string patternForecast = @"^Source: ([A-Za-z0-9]+)"+"$";
                    var matchForcast = Regex.Match(input, patternForecast);
                    if (matchForcast.Success)
                    {
                        second = true;
                        forecast = matchForcast.Groups[1].Value.ToString();
                        continue;
                    }
                }
                if((third==false)&&(second==true)&&(first==true))
                {
                    string patternSource = @"^Forecast: ([^!\.,?]+)"+"$";
                    var matchSource = Regex.Match(input, patternSource);
                    if (matchSource.Success)
                    {
                        third = true;
                        source = matchSource.Groups[1].Value.ToString();
                    }
                }
                if((first)&&(second)&&(third))
                {
                    output.Add($"({type}) {source} ~ {forecast}");
                    first = false;
                    second = false;
                    third = false;
                    type = "";
                    forecast = "";
                    source = "";
                }

            }
            if(output.Count==0)
            {
                Console.WriteLine();
            }
            else
            {
                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
