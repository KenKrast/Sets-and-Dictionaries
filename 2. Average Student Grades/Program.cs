using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<decimal>> studentGrade = new Dictionary<string, List<decimal>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!studentGrade.ContainsKey(name))
                {
                    studentGrade.Add(name, new List<decimal>());
                }
                studentGrade[name].Add(grade);
            }

            foreach (var item in studentGrade)
            {
                Console.Write($"{item.Key} -> ");
                foreach (decimal grade in item.Value)
                {
                    Console.Write($"{grade} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }

    }
}
