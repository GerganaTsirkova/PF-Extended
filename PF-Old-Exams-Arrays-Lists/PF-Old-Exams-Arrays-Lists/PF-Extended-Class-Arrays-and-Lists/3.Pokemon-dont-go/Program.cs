using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Pokemon_dont_go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long sumRemoved = 0;

            while (pokemons.Count != 0)
            {
                int poke = int.Parse(Console.ReadLine());
                if (poke < 0)
                {
                    int removed = pokemons[0];
                    sumRemoved += removed;
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removed)
                        {
                            pokemons[i] += removed;
                        }
                        else
                        {
                            pokemons[i] -= removed;
                        }
                    }
                }
                else if ((poke >= 0) && (poke <= pokemons.Count - 1))
                {
                    int removed = pokemons[poke];
                    sumRemoved += pokemons[poke];
                    pokemons.RemoveAt(poke);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removed)
                        {
                            pokemons[i] += removed;
                        }
                        else
                        {
                            pokemons[i] -= removed;
                        }
                    }
                }
                else if (poke >= pokemons.Count)
                {
                    int removed = pokemons[pokemons.Count - 1];
                    sumRemoved += removed;
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removed)
                        {
                            pokemons[i] += removed;
                        }
                        else
                        {
                            pokemons[i] -= removed;
                        }
                    }
                }
            }
            Console.WriteLine(sumRemoved);
        }
    }
}
