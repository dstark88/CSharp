using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            // Set row 0
            jagged[0] = new int[2];
            jagged[0][0] = 8;
            jagged[0][1] = 10;

            // Set row 1, if not listed the value at each index is 0
            jagged[1] = new int[9];

            // Set row 2
            jagged[2] = new int[4] { 20, 30, 40, 50 };

            Console.WriteLine("At row 2, col 0: " + jagged[2][0]);

            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
            }
            myArray[2] = 10;
            myArray.SetValue(3, 8);
            Console.WriteLine("myArray console: " + myArray[3]);
        }
    }
}
