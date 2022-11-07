using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> numbers = new Dictionary<int,int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int fillDict = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(fillDict))
                {
                    numbers.Add(fillDict, 0);
                }
                numbers[fillDict]++;
            }

            Console.WriteLine(numbers.Single(n => n.Value % 2 == 0).Key);
        }
    }
}
