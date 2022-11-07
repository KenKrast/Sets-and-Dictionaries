using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dictionary =
                new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];

                if (!dictionary.ContainsKey(color))
                {
                    dictionary[color] = new Dictionary<string, int>();
                }

                for (int j = 1; j < tokens.Length; j++)
                {
                    string currentClothing = tokens[j];

                    if (!dictionary[color].ContainsKey(currentClothing))
                    {
                        dictionary[color].Add(currentClothing, 0);
                    }

                    dictionary[color][currentClothing]++;
                }
            }

            var findItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var dict in dictionary)
            {
                Console.WriteLine($"{dict.Key} clothes:");
                foreach (var dict2 in dict.Value)
                {
                    string printItem = $"* {dict2.Key} - {dict2.Value}";
                    if (dict.Key == findItem[0] && dict2.Key == findItem[1])
                    {
                        printItem += " (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
