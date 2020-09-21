using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_KeepHydrated
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = 5;

            int liters = Litres(time);
            Console.WriteLine("Natan needs to drink {0} liters", liters);
        }
        public static int Litres(double time)
        {
            double amount = 0;

            if (time % 2 == 0)
            {
                amount = time / 2;
            }
            else
            {
                amount = (time - 1) / 2;
            }
            int convert = Convert.ToInt32(amount);
            return convert;
        }
    }
}
//Nathan loves cycling
//Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
//You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.
//For example:
//time = 3 ----> litres = 1
//time = 6.7---> litres = 3
//time = 11.8--> litres = 5

//other solutions
//public static int Litres(double time)
//{
//    return (int)(time / 2);
//}