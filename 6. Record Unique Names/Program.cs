using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _6._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int nums = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine("strings were cleared");
            Console.WriteLine(String.Join(" \n", names));
            Regex br = new Regex("@sdhdvihdcsd");
        }
    }
}
