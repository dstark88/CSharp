using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Denise's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");

            // var x = 34.1;
            // var y = 10.3;
            // var result = x + y;
            // Console.WriteLine(result);

            //  var numbers = new[] {12.3, 10.3, 6.11}; // dont need to type new double[3], it can tell by how many are listed
            /*List<double>*/
            //var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            //grades.Add(56.1);
            // grades[0]; can get into it much like an array

            // numbers[0] = 12.3;
            // numbers[1] = 10.3;
            // numbers[2] = 6.11;

            // var result = numbers[0];
            // result += numbers[1];
            // result += numbers[2];

            // var total = 0.0;
            // foreach(var number in numbers) 
            // {
            //     total += number;
            // }
            // Console.WriteLine(total);

            //var result = 0.0;
            //var highGrade = double.MinValue;
            //var lowGrade = double.MaxValue;

            //foreach (var number in grades)
            //{
            //    //if(number < highGrade)
            //    //{
            //    //    highGrade = number;
            //    //}
            //    highGrade = Math.Max(number, highGrade);
            //    lowGrade = Math.Min(number, lowGrade);
            //    result += number;
            //}
            //result /= grades.Count; // result = result / grades.Count
            //Console.WriteLine($"The lowest grade is {lowGrade}");
            //Console.WriteLine($"The highest grade is {highGrade}");
            //Console.WriteLine($"The average grade is {result:N2}");

            // if (args.Length > 0)
            // {
            //     Console.WriteLine($"Hello, {args[0]}!");
            // }
            // else
            // {
            //     Console.WriteLine("Hello!");
            // }
        }

    }
}