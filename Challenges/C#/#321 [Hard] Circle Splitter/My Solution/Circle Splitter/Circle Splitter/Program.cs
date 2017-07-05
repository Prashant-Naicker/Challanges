using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Splitter
{
    class Program
    {
        static int[] x;
        static int[] y;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of points you want to add.");
            int nPoints = int.Parse(Console.ReadLine());

            storeCoords(nPoints);

            Console.WriteLine(x[1]);

        }

        static void storeCoords(int nPoints)
        {
            x = new int[nPoints];
            y = new int[nPoints];

            for (int i = 0; i < nPoints; i++)
            {
                Console.WriteLine("Please enter coordinate");
                string[] coord = Console.ReadLine().Split(' ');
                int[] coordInt = new int[2];
                coordInt = Array.ConvertAll(coord, int.Parse);
                x[i] = coordInt[0];
                y[i] = coordInt[1];
            }
        }
    }
}
