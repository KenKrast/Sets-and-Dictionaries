using System;
using System.Collections.Generic;

namespace _5._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> world = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = splitted[0];
                string country = splitted[1];
                string city = splitted[2];

                if (!world.ContainsKey(continent))
                {
                    world.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!world[continent].ContainsKey(country))
                {
                    world[continent].Add(country, new List<string>());
                }

                world[continent][country].Add(city);

            }

            foreach (var item in world)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
