using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueElements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();
                uniqueElements.UnionWith(elements);
            }

            Console.WriteLine(string.Join(" ", uniqueElements.OrderBy(el=> el)));
        }
    }
}
