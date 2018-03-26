using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var broadcasts = new List<KeyValuePair<string, string>>();
            var messages = new List<KeyValuePair<string, string>>();

            while(input != "Hornet is Green")
            {
                string messagesPattern = @"^([\d]+) <-> ([A-Za-z0-9]+)$";
                string broadcastPattern = @"^([\WA-Za-z]+) <-> ([A-Za-z0-9]+)$";
                Match messageMatch = Regex.Match(input, messagesPattern);
                Match broadcastMatch = Regex.Match(input, broadcastPattern);
                if (messageMatch.Success)
                {
                    string recipient = messageMatch.Groups[1].Value.ToString();
                    char[] arr = recipient.ToCharArray();
                    Array.Reverse(arr);
                    string resultedRecipient = new string(arr);
                    string messge = messageMatch.Groups[2].Value.ToString();
                    messages.Add(new KeyValuePair<string, string>(resultedRecipient, messge));
                }
                else if (broadcastMatch.Success)
                {
                    string freq = broadcastMatch.Groups[2].Value;
                    string frequency = MakingSmallBigAndBigSmall(freq);
                    string message = broadcastMatch.Groups[1].Value;
                    broadcasts.Add(new KeyValuePair<string, string>(frequency, message));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if(broadcasts.Count>0)
            {
                foreach (var pair in broadcasts)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var pair in messages)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static string MakingSmallBigAndBigSmall(string freq)
        {
            string toRemake = freq.ToString();
            char[] arr = toRemake.ToCharArray();
            string result = "";
            for (int i = 0; i < toRemake.Length; i++)
            {
                if ((Char.IsLetter(arr[i]))&&((arr[i]>=65)&&(arr[i]<=90)))
                {
                    arr[i] += (char)32;
                    
                }
                else if((Char.IsLetter(arr[i])) && ((arr[i] >= 97) && (arr[i] <= 122)))
                {
                    arr[i] -= (char)32;
                }
                result += arr[i];
            }
            return result;
        }
    }
}
