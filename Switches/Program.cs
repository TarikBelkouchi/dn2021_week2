﻿using System;

namespace Switches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter Pizza, Apple, or Coffee.");
            string entry = Console.ReadLine();



            /*
            if (entry == "Pizza")
            {
                Console.WriteLine("Pizza is fun to have for dinner.");
            }
            else if (entry == "Apple")
            {
                Console.WriteLine("An apple a day keeps the doctor away.");
            }
            else if (entry == "Coffee")
            {
                Console.WriteLine("Cofefee gets you going every morning");
            }
            else
            {
                Console.WriteLine("I have no idea what that means");
            }

            */

            switch (entry)
            {
                case "Pizza":
                    Console.WriteLine("Pizza is fun to have for dinner.");
                    break;
                case "Apple":
                    Console.WriteLine("An apple a day keeps the doctor away.");
                    break;
                case "coffee":
                    Console.WriteLine("Cofefee gets you going every morning");
                    break;
                default:
                    Console.WriteLine("I have no idea what that means");
                    break;

                    //Does the same as above^^^ a little faster method.

            }
        }
    }
}
