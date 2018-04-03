using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.SpyGram
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyMessage = Console.ReadLine();
            string input = Console.ReadLine();
            var data = new List<KeyValuePair<string, string>>();
            while (input != "END")
            {
                string pattern = @"TO: ([A-Z]+); MESSAGE: (.*);";
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string senderName = match.Groups[1].Value.ToString();
                    string messageToCode = match.ToString();
                    char[] arr = new char[messageToCode.Length];
                    int key = 0;
                    for (int i = 0; i < messageToCode.Length; i++)
                    {

                        int num = messageToCode[i] + keyMessage[key % keyMessage.Length] - 48;
                        arr[i] = (char)(num);
                        key++;

                    }
                    string res = new string(arr);
                    data.Add(new KeyValuePair<string, string>(res, senderName));
                }
                input = Console.ReadLine();
            }
            foreach (var item in data.OrderBy(x => x.Value))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
