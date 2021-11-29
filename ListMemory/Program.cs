using System;
using System.Collections.Generic; //type using space sys tab dot g tab

namespace ListMemory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Fred");
            names.Add("Sally");

            List<string> more;
            more = names;
            Console.WriteLine(more[0]);

            more[0] = "Frank";

            Console.WriteLine(names[0]);

            names.Add("Harold");

            Console.WriteLine("Print out the list names points to.");

            foreach (string word in names)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Print out the list more pints to.");

            foreach (string word in more)
            {
                Console.WriteLine(word);
            }

        }
    }
}
