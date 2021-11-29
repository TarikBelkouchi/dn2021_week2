using System;
using System.Collections.Generic;
//add this in the beginning so you don't have to do it manually

namespace DictionaryDemo2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> temps = new Dictionary<string, int>();
            temps["Grand Rapids"] = 75;
            temps["Detroit"] = 75;
            temps["Columbus"] = 80;
            temps["Orlando"] = 95;

            foreach (var pair in temps)
            {
                Console.WriteLine($"{ pair.Key} has a temperature of {pair.Value}.");
            }

            Console.WriteLine("Grand Rapids");
            Console.WriteLine(temps["Grand Rapids"]);

            //get all the keys and loops
            Console.WriteLine("\n Let's get all the keys and loop throught them");
            foreach (string key in temps.Keys)
            {
                Console.WriteLine($"this key is {key}.");
                int theValue = temps[key];
                Console.WriteLine($"The temperature is (theValue)");
            }

            Console.WriteLine("\nPlease enter a city");
            string entry = Console.ReadLine();
            //Console.WriteLine(temps[entry]);
            //Console.WriteLine($:the tempatrue at {entry} is {temmp[entry]});

            
            if (temps.ContainsKey(entry))
            {
                Console.WriteLine($"The tempature at {entry} is {temps[entry]}");
            }
            else
            {
                Console.WriteLine("Sorry I don't know where that is");
            }
            

            
        }
    }
}

           