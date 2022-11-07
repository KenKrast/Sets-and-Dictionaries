using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

public class exercise14
{
    public static char[] arrV, arrC;
    public static string[] words = { "pear", "flour", "pork", "olive" };
    public static int[] wordCounts = { 0, 0, 0, 0 };
    public static string strV, strC;
    public static int iterateVC = 0;
    public static void iterateV()
    {
        if (iterateVC < strV.Length)
        {
            int index = 0;
            foreach (var w in words)
            {
                if (w.ToString().Contains(arrV[0]))
                {
                    wordCounts[index] = wordCounts[index] + 1;
                }
                index++;
            }
            string output = strV.Substring(1) + strV[0];
            arrV = output.ToCharArray();
            strV = new string(arrV);
            iterateVC++;
        }
    }

    public static void iterateC()
    {
        int index = 0;
        foreach (var w in words)
        {
            if (w.ToString().Contains(arrC[arrC.Length - 1]))
            {
                wordCounts[index] = wordCounts[index] + 1;
            }
            index++;
        }
        string output = strC.Remove(strC.Length - 1);
        arrC = output.ToCharArray();
        strC = new string(arrC);
    }

    public static void Main()
    {
        Console.Write("\nCheck whether a given substring is present in the given string :\n");
        Console.Write("-------------------------------------------------------------------\n");
        Console.Write("Input the vowels : ");
        strV = Console.ReadLine().Replace(" ", string.Empty); ;
        arrV = strV.ToCharArray();
        Console.Write("Input the consonants : ");
        strC = Console.ReadLine().Replace(" ", string.Empty); ;
        arrC = strC.ToCharArray();
        while (arrC.Length > 0)
        {
            iterateV();
            iterateC();
        }

        List<string> results = new List<string>();
        for (int i = 0; i <= words.Length - 1; i++)
        {
            if (wordCounts[i] == words[i].Length)
            {
                results.Add(words[i]);

            }
        }
        Console.Write("\n\nOutput :" + results.Count + "\n");
        foreach (var r in results)
        {
            Console.Write("\n\n" + r);
        }
        Console.ReadKey();

    }



}
