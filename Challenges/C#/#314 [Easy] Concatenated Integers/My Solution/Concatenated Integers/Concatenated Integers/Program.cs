using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenated_Integers
{
    class Program
    {
        static List<string> list;

        static void Main(string[] args)
        {
            string maxDig = "0";

            Console.WriteLine("Enter a list of integers:");
            string line = Console.ReadLine();

            list = addLineToList(line);   

            for (int i = 0; i < list.Count(); i++)
            {
                if (maxDig[0] == list[i][0])
                {
                    if (maxDig.Length == 1) { continue; }
                    if (list[i].Length == 1) { maxDig = list[i]; continue; }
                }
                if (maxDig[0] < list[i][0]) {
                    maxDig = list[i];
                }         
            }
        }

        static List<string> addLineToList(string line)
        {
            List<string> list = new List<string>();
            string currentVal = "";

            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ') {
                    list.Add(currentVal);
                    currentVal = "";
                    continue;
                }
                currentVal += line[i];
            }
            return list;
        }
    }
}
