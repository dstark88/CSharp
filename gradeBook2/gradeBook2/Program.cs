using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace gradeBook2
{
    class Program
    {
        static void Main(string[] args)
        {  
            var x = 34.1;
            var y = 10.3;
            // var result = x + y;
            // Console.WriteLine(result);

           //  var numbers = new[] {12.3, 10.3, 6.11}; // dont need to type new double[3], it can tell by how many are listed
            /*List<double>*/ var grades = new List<double>() {12.3, 10.3, 6.11};
            grades.Add(56.1);
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
            
            var result = 0.0;
            foreach(var number in grades) 
            {
                result += number;
            }
            result /= grades.Count; // result = result / grades.Count
            Console.WriteLine($"The average grade is {result:N2}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }

    }
}
