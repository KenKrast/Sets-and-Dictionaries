using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(y => int.Parse(y)).ToList();

            numbers = numbers.OrderByDescending(x=>x).ToList(); //Take(3)

            //Console.WriteLine(string.Join(" ", numbers));
            int count = numbers.Count();
            if (count > 3)
            {
                count = 3;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
