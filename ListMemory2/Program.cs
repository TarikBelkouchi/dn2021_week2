using System;
using System.Collections.Generic;

namespace ListMemory2
{
    class MainClass
    {
        public static void Modify(List<string> mylist)
        {
            mylist.Add("Frank");
        }


        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Fred");
            names.Add("Sally");

            Modify(names);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }



    }
}
