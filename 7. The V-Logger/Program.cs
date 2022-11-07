using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _7._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<Vlogger> vloggerList = new List<Vlogger>();
             while (true)
             {
                 string commands = Console.ReadLine();
                 if (commands == "Statistics")
                 {
                     break;
                 }

                 string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[1];
                string vloggerName = tokens[0];
                string followVloger = tokens[2];
                if (action == "Joined")
                {
                    if (!vloggerList.Any(v=> v.Name == vloggerName))
                    {
                        vloggerList.Add(new Vlogger(vloggerName));
                    }
                }
                else
                {
                    if (vloggerName == followVloger 
                        || !vloggerList.Any(v=>v.Name == vloggerName
                        || !vloggerList.Any(v=>v.Name == followVloger)))
                    {
                        continue;
                    }

                    Vlogger vlogger = vloggerList.Single(v => v.Name == vloggerName);
                    vlogger.Following.Add(followVloger);

                    Vlogger vloggerToFollow = vloggerList.Single(v => v.Name == followVloger);
                    vloggerToFollow.Followers.Add(vloggerName);

                }
             }

             vloggerList = vloggerList
                 .OrderByDescending(v=>v.Followers.Count)
                 .ThenByDescending(v=>v.Following.Count)
                 .ToList();

             Console.WriteLine($"The V-Logger has a total of {vloggerList.Count} vloggers in its logs.");

             int count = 1;
             foreach (var vloger in vloggerList)
             {
                 Console.WriteLine($"{count}. {vloger.Name} : {vloger.Followers.Count} followers, {vloger.Following.Count} following");
                 if (count == 1)
                 {
                     foreach (var vloggerFollower in vloger.Followers)
                     {
                         Console.WriteLine($"*  {vloggerFollower}");
                     }
                 }

                 count++;
             }
        }
    }

    public class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new SortedSet<string>();
            Following = new HashSet<string>();
        }
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; } 
        public HashSet<string> Following { get; set; } 
    }
}
