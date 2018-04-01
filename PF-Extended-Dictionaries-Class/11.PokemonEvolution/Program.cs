using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var pokemons = new Dictionary<string, List<string>>();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }
                string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (tokens.Length > 1)
                {
                    string name = tokens[0];
                    string type = tokens[1];
                    int evolution = int.Parse(tokens[2]);
                    if(!pokemons.ContainsKey(name))
                    {
                        var inner = new List<string>();
                        inner.Add($"{type} <-> {evolution}");
                        pokemons.Add(name,inner);
                    }
                    else
                    {
                        pokemons[name].Add($"{type} <-> {evolution}");
                    }
                }
                else
                {
                    string name = tokens[0];
                    if(pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var item in pokemons[name])
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var item in pokemon.Value.OrderByDescending(x=>int.Parse(x.Split(new char[] {' ','<','>','-'},StringSplitOptions.RemoveEmptyEntries).Last())))
                {
                    Console.WriteLine(item);
                }
                
            }
        }
    }
}
