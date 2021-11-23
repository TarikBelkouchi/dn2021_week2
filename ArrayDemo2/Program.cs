using System;

namespace ArrayDemo2
{
    class MainClass
    {

        public static void PrintMenu(string[] theItems, decimal[] thePrices)
        {
            Console.WriteLine("Here is our menu!");
            for (int i = 0; i < theItems.Length; i++)
            {
                Console.WriteLine($"{theItems[i],-12}{ thePrices[i],-6}");
            }


        }
        public static int FindItem(string[] theItems, string search)
        {
            for (int i = 0; i < theItems.Length; i++)
            {
                if (theItems[i].ToLower() == search.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool GoAgain()
        {
            
            Console.WriteLine("Would you like to go again?");
            string entry = Console.ReadLine();
            if(entry.ToLower() == "n")
            {
                return false;
            }
            if (entry.ToLower() == "y")
            {
                return true;
            }
            Console.WriteLine("I'm sorry I don't know what you mean.");
        }


        public static void Main(string[] args)
        {
            //On this second demo we will learn how to write multiple arrays,
            //creating data

            // creating a menu at a coffee house
            //Items         price
            //,,,,,         ......
            //coffee        2.00
            //espresso      2.50
            //muffin        3.50
            //croissant     4.00

            //
            //we'll create one array for items, and one array for price

            string[] items = new string[] { "Coffee", "Esspresso", "Muffin", "Croissant" };
            decimal[] prices = new decimal[] { 2.00m, 2.50m, 3.50m, 4.00m };

            PrintMenu(items, prices);


            Console.WriteLine("Please make a selection");
            string entry = Console.ReadLine();
            int index = FindItem(items, entry);
            Console.WriteLine(index);

            if (index > -1)
            {
                Console.WriteLine($"The price of {entry[index]} is {prices[index]}");
            }
            else
            {
                Console.WriteLine($"Sorry, we do not have {entry}!");
            }
            //
            //
            //
            //
            //for (int i = 0; i < items.Length; i++)
            //{
            //if (items[i] == entry) "original"
            //if we want to make sure its case sensitive
            //if (items[i].ToLower() == entry.ToLower())
            //{
            //    Console.WriteLine($"The price of {entry} is {prices[i]}");
            //    break;
            //}


            //}









        }
    }
}