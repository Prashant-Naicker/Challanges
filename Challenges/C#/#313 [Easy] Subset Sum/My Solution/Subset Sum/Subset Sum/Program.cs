using System;
using System.Collections.Generic;

delegate List<int> sortList(int[] a);

namespace Subset_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of numbers:");
            string[] strVals = Console.ReadLine().Split(' ');

            int[] intVals = Array.ConvertAll(strVals, s => int.Parse(s));

            sortList n = getAllNegatives;
            sortList p = getAllPositives;

            List<int> negatives = n(intVals);
            List<int> positives = p(intVals);

            int negativesTotal = getTotal(negatives);
            int positivesTotal = getTotal(positives);

            if (negativesTotal + positivesTotal == 0)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
            Console.WriteLine("false");
            Console.ReadLine();
        }

        static List<int> getAllNegatives(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) { Console.WriteLine("true"); Console.ReadLine(); }
                if (arr[i] < 0) { list.Add(arr[i]);  }
            }

            return list;
        }

        static List<int> getAllPositives(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) { Console.WriteLine("true"); Console.ReadLine(); }
                if (arr[i] > 0) { list.Add(arr[i]); }
            }

            return list;
        }

        static int getTotal(List<int> list)
        {
            int total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i];
            }

            return total;
        }
    }
}
