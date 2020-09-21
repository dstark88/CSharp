using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AbbreviateTwoWordName
{
    class Program
    {
        public static string AbbrevName(string name)
        {
            string[] namesList = name.Split(' ');
            string firstName = "";
            string lastName = "";
            var firstInt = "";
            var lastInt = "";
            string[] firstNameLetters = firstName.ToChar;
            string[] lastNameLetters = lastName.Split('');
            foreach (var nameList in namesList)
            {
                firstName = namesList[0];
                lastName = namesList[1];
            }
            foreach (var firstNameLetter in firstNameLetters)
            {
                firstInt = firstNameLetters[0];
            }
            foreach (var lastNameLetter in lastNameLetters)
            {
                lastInt = lastNameLetters[0];
            }

            return (firstInt + "." + lastInt);
        }
        static void Main(string[] args)
        {
            string name = "Sam Harris";
            Console.WriteLine(AbbrevName(name));
        }
    }
}

//8 kyu
//Abbreviate a Two Word Name

//Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.

//The output should be two capital letters with a dot separating them.

//It should look like this:
//Sam Harris => S.H
