using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> numOfTimes = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numOfTimes.ContainsKey(number))
                {
                    numOfTimes.Add(number, 0);
                }
                numOfTimes[number]++;
            }

            foreach (var numOfTime in numOfTimes)
            {
                Console.WriteLine($"{numOfTime.Key} - {numOfTime.Value} times");
            }
        }
    }
}
