using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ArrayPlusArray
{
    class Program
    {
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            int sumArr1 = 0;
            int sumArr2 = 0;

            for (var i = 0; i < arr1.Length; i++)
            {
                sumArr1 += arr1[i];
            }
            for (var i = 0; i < arr2.Length; i++)
            {
                sumArr2 += arr2[i];
            }

            return sumArr1 + sumArr2;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            Console.WriteLine(ArrayPlusArray(arr1, arr2));
        }
    }
}

//8 kyu
//Array plus array

//I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. 
//I'll appreciate for your help.

//P.S.Each array includes only integer numbers.Output is a number too.