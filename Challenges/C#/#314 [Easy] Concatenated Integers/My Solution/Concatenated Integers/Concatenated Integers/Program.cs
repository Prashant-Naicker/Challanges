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
            string lowestNum = "";
            string largestNum = "";       
            string suitNum = "";

            int Count = 0;       

            Console.WriteLine("Enter a list of integers:");
            string line = Console.ReadLine();

            list = addLineToList(line);

            string[] finalList = new string[list.Count];

            while (list.Count > 0) 
            {
                suitNum = list[list.Count - 1];
                for (int j = 0; j < list.Count; j++)
                {                  
                    suitNum = findSuitableNumber(suitNum, list[j]);
                }
                finalList[Count] = suitNum;
                list.Remove(suitNum);
                Count++;
            }
            
            for (int i = 0; i < finalList.Length; i++)
            {
                largestNum += finalList[i];
            }

            for (int i = finalList.Length - 1; i >= 0; i--)
            {
                lowestNum += finalList[i];
            }

            Console.WriteLine(largestNum);
            Console.WriteLine(lowestNum);
            Console.ReadLine();

        }

        static string findSuitableNumber(string num1, string num2)
        {
            string suitableNum = num1;
            int sizeNum1 = num1.Length;
            int sizeNum2 = num2.Length;
            int sizeDiff = Math.Abs(sizeNum2 - sizeNum1);

            int smallerSize = sizeNum1 > sizeNum2 ? sizeNum2 : sizeNum1;
            bool num1Bigger = sizeNum1 > sizeNum2 ? true : false;

            for (int i = 0; i < smallerSize; i++)
            {
                if (num1[i] == num2[i]) { continue; }
                suitableNum = num1[i] > num2[i] ? num1 : num2;
                return suitableNum;
            }

            for (int i = smallerSize; i < smallerSize + sizeDiff; i++)
            {
                if (num1Bigger) { suitableNum = num1[i] > num2[0] ? num1 : num2; }
                else { suitableNum = num2[i] > num1[0] ? num2 : num1;  }
            }

            return suitableNum;
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

                if (i == line.Length - 1) { list.Add(currentVal); }
            }
            return list;
        }
    }
}
