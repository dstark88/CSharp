using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CanWeDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -12;
            int a = 2;
            int b = -6;

            bool equals = is_divide_by(number, a, b);
            Console.WriteLine("The value {0}", equals);
        }

        public static bool is_divide_by(int number, int a, int b)
        {
            if ((number % a == 0) && (number % b == 0))
            {
                return true;
            } 
            else {
                return false;
            }
        }
    }
}
//Your task is to create functionisDivideBy(or is_divide_by) to check if an integer number is divisible by each out of two arguments.
//other solutions 

//public static bool is_divide_by(int number, int a, int b)
//{
//    return number % a == 0 && number % b == 0;
//}