using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (!dictionary.ContainsKey(c))
                {
                    dictionary.Add(c, 0);
                }
                dictionary[c]++;
            }

            foreach (KeyValuePair<char,int> c in dictionary)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}
