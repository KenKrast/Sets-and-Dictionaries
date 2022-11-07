using System;
using System.Collections.Generic;

namespace _1._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usersLength = int.Parse(Console.ReadLine());
            HashSet<string> userData = new HashSet<string>();
            for (int i = 0; i < usersLength; i++)
            {
                string userName = Console.ReadLine();
                userData.Add(userName);
            }

            Console.Write(string.Join(" \n", userData));
            
        }
    }
}
