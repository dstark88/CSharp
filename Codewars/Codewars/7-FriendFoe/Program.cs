using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FriendFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Josh", "Alex", "Beth", "Paul", "Luke", "Caraly", "Dustin" };
            Console.WriteLine(FriendOrFoe(names));
        }
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> Friend = new List<string>();
            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    Friend.Add(name);
                }
            }
            return Friend;
        }
    }
}

//Make a program that filters a list of strings and returns a list with only your friends name in it.

//If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...

//Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

//i.e.

//friend["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]
//Note: keep the original order of the names in the output.
