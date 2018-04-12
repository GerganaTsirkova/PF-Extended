using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4.CubicsMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>();
            while(true)
            {
                string input = Console.ReadLine();
                if(input== "Over!")
                {
                    break;
                }
                int number = int.Parse(Console.ReadLine());
                string pattern = $@"^[\d]+([A-Za-z]+)([^A-Za-z]*)$";
                var match = Regex.Match(input, pattern);
                string messageExtracted = "";
                string verificationCode = "";
                var result = new StringBuilder();
                if(match.Success)
                {
                    messageExtracted = match.Groups[1].Value.ToString();
                    if(messageExtracted.Length==number)
                    {
                        string verificCode = new String(input.Where(Char.IsDigit).ToArray());
                        for (int i = 0; i < verificCode.Length; i++)
                        {
                            string patternDigint = @"(\d)";
                            var matchDigit =Regex.Match(verificCode[i].ToString(),patternDigint);
                            int ch = int.Parse(matchDigit.ToString());
                            if ((ch >= 0) && (ch < messageExtracted.Length))
                            {
                                result.Append(messageExtracted[ch]);
                            }
                            else
                            {
                                result.Append(" ");
                            }
                        }
                        verificationCode = result.ToString();
                        string stringToAdd = $"{messageExtracted} == {verificationCode}";
                        myList.Add(stringToAdd);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
