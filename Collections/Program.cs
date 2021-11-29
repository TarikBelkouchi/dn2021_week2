using System;
using System.Collections.Generic;

namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            //above is how you would create a new collections
            names.Add("Fred");
            names.Add("Sally");

            //above is how you would add names to that collection

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            names.Add("Julia");
            Console.WriteLine(names[2]);
            // The command must be wrtten after the string was added, or it won't be recognized.

            Console.WriteLine(names.Contains("Fred"));
            Console.WriteLine(names.Contains("Pizza"));
            // How to check if the collection has either string
            //first is true, second is false

            Console.WriteLine("Now let's remove Fred");
            names.Remove("Fred");
            Console.WriteLine(names[0]);
            //With Fred removed the list shifts Sally to first on the list.

            Console.WriteLine("let's remove by index, instead of names");
            names.RemoveAt(1);//Index means remove 2nd on the list
            Console.WriteLine(0);
            //Since we deletes the 2nd(julia) we will print Sally

            //Let's add names to collections
            Console.WriteLine("Let's add names to collections");
            names.Add("Jack");
            names.Add("Alison");
            names.Add("Dylan");
            names.Add("Erica");

            //Now we'll try to loop them
            Console.WriteLine("Let's loop through them using a for loop");
            for (int i = 0; i < names.Count; i ++)
            {
                //We are indside the loop and our index is {i}.
                Console.WriteLine($"We are indside the loop and our index is {i}.");
                Console.WriteLine($"{i} : {names[i]}");
            }

            //Now we'll try a "for each" loop
            Console.WriteLine("\n Now let's use a for each loop");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
