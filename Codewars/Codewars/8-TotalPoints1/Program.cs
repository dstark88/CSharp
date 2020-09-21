using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _8_TotalPoints
{
    class Program
    {
        public static int TotalPoints(string[] games)
        {
            // split sting to x and y which are ints on the :
            int points = 0;

            foreach (var game in games)
            {

                System.Console.WriteLine($"game score: {game}");

                if (game[0] > game[2])
                {
                    points += 3;
                }
                else if (game[0] == game[2])
                {
                    points += 1;
                }
            }

            return points;
        }

        static void Main(string[] args)
        {
            string[] games = { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };

            Console.WriteLine(TotalPoints(games));
        }
    }
}

//Our football team finished the championship.The result of each match look like "x:y". Results of all matches are recorded in the collection.

//For example: ["3:1", "2:2", "0:1", ...]

//Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:

//if x>y - 3 points
//if x<y - 0 point
//if x=y - 1 point
//Notes:

//there are 10 matches in the championship
//0 <= x <= 4
//0 <= y <= 4