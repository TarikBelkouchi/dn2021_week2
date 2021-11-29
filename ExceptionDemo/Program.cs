using System;
using System.Collections.Generic;

namespace ExceptionDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Fred");
            names.Add("Sally");
            names.Add("Julia");

            /*
            Console.WriteLine("Who is going next? Please enter a number :");
            string entry = Console.ReadLine();


            int num = 0;

            try
            {
                num = int.Parse(entry);
            }
            catch (Exception ex)
            {
                Console.WriteLine("That's not a number!!!");

            }

            try
            {
                Console.WriteLine(names[num]);
            }
            catch (Exception ex)
            {
                // The following commented out lines really aren't user friendly
                //Console.WriteLine("An error occurred!!!");
                //Console.WriteLine(ex.Message);
                Console.WriteLine($"Please enter a number between 0 and {names.Count -1}");
            }
            */
            int num = 0;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Who is going Next? Please enter a number.");
                string entry = Console.ReadLine();

                if (int.TryParse(entry, out num) == false)
                {
                    Console.WriteLine("That isn't a number!");
                    Console.WriteLine("Please try again!");
                }

                else
                {
                    //We know its  a valid number. Now let's make sure it's inside the correct range.
                    if (num >= 0 && num < names.Count)
                    {

                    
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine($"Although thats a number, it's not in the correct range. Please enter between 0 and {names.Count - 1}.");
                    }
                }
            }
            Console.WriteLine($"Thank you! you entered {num}");


        }
    }
}
