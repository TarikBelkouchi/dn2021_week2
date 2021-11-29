using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Let's make a dictionary of state capitols

            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["Michigan"] = "Lansing";
            capitals["Ohio"] = "Columbus";
            capitals["California"] = "Sacremento";
            capitals["Georgia"] = "Atlanta";

            Console.WriteLine("Let's print out a couple of these");
            Console.WriteLine(capitals["Ohio"]);
            Console.WriteLine(capitals["Georgia"]);

            // change capitol of MI to detroit
            capitals["Michigan"] = "Detroit";

            //Add another
            capitals["Indiana"] = "Indianoplolis";

            // this is an foreach loop/ lists each pair
            Console.WriteLine("Let's a for each loop.");
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }







        }
    }
}
