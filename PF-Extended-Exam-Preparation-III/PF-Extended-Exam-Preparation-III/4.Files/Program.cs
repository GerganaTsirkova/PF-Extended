
using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var dictFiles = new Dictionary<string, Dictionary<string, decimal>>();
            //root<file,size
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split('\\').ToArray();
                string root = tokens[0];
                string name = tokens[tokens.Length - 1];
                string[] token = name.Split(';').ToArray();
                string fileName = token[0];
                decimal size = decimal.Parse(token[1]);
                if(!dictFiles.ContainsKey(root))
                {
                    var inner = new Dictionary<string, decimal>();
                    inner.Add(fileName, size);
                    dictFiles.Add(root, inner);
                }
                else
                {
                    if(dictFiles[root].ContainsKey(fileName))
                    {
                        dictFiles[root][fileName] = size;
                    }
                    else
                    {
                        dictFiles[root].Add(fileName, size);
                    }
                }
            }
            string[] inp = Console.ReadLine().Split().ToArray();
            string rootToSearch = inp[2];
            string exeFileToExtract = inp[0];
            int counter = 0;
            foreach (var item in dictFiles.OrderByDescending(x=>dictFiles[x.Key].Values.First()))
            {
                foreach (var file in item.Value.OrderBy(x=>x.Key))
                {
                    if((file.Key.Contains(exeFileToExtract))&&(item.Key==rootToSearch))
                    {
                        counter++;
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
                
            }
            if(counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
