using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _7._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();
            while (input != "End")
            {
                try
                {
                    string[] inputParams = Regex.Split(input, ", ");
                    if (inputParams[0] == "IN")
                    {
                        parking.Add(inputParams[1]);
                    }
                    else if (inputParams[0] == "OUT")
                    {
                        parking.Remove(inputParams[1]);
                    }

                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }

            Console.WriteLine(string.Join(" ", parking));
        }
    }
}
