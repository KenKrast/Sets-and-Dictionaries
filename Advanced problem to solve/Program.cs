using System;
using System.Collections.Generic;
using System.Linq;
namespace K2_caffeine
{
    class Program
    {
        public static int[] arrC, arrE;
        public static int limitperday = 300;
        public static int SC = 0;


        public static void iterate()
        {
            int currentC = arrC[arrC.Length - 1] * arrE[0];
            if (limitperday > (currentC + SC))
            {
                SC += currentC;
                if (arrE.Length > 0)
                {
                    var arrEList = arrE.ToList();
                    arrEList.RemoveAt(0);
                    arrE = arrEList.ToArray();
                }
            }
            else
            {
                SC = SC - 30;
                if (arrE.Length > 0)
                {
                    arrE.Reverse();

                }

            }

            var arrCList = arrC.ToList();
            arrCList.RemoveAt(arrCList.Count - 1);
            arrC = arrCList.ToArray();
        }
        public static void Main()
        {
            arrC = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            arrE = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (arrC.Length > 0)
            {
                if (arrE.Length > 0)
                    iterate();
                else
                    break;
            }


            if (arrE.Length > 0)
            {
                Console.Write("Drinks left:");
                foreach (var r in arrE)
                {
                    Console.Write(" " + r);
                }
            }

            if (arrE.Length == 0)
            {
                Console.Write("\nAt least Stamat wasn't exceeding the maximum caffeine.\n");
            }

            if (SC > 0)
            {
                Console.Write("\nStamat is going to sleep with " + SC + " mg caffeine.\n");
            }
        }
    }
}
