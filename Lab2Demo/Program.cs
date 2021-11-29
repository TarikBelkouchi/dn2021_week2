using System;
using System.Collections.Generic;

namespace Lab2Demo
{
    class MainClass
    {
        static void PrintMenu(Dictionary<string, decimal> menu)
        {
            Console.WriteLine("Welcome to the Store!");
            foreach (var pair in menu)
            {
                Console.WriteLine($"{ pair.Key} {pair.Value}");
            }

        }

        static void PrintCart(List<string> cart, Dictionary<string, decimal> menu)
        {
            decimal sum = 0.00m;
            Console.WriteLine("here are your items!");
            foreach(string item in cart)
            {
                Console.WriteLine($"{item} price{menu[item]}");
                //sum = sum + menu[item];
                sum += menu[item];

            }
            Console.WriteLine($"Your total is {sum}.");
        }


        public static void Main(string[] args)
        {
            /*
            Our data model:

            1. A dictionar mapping an item name to a price
            2. A list containing items the shopper is going to purchase i.e. the cart or basket

            */


            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            List<string> cart = new List<string>();

            //Add some items to the menu
            menu["Milk"] = 2.00m;
            menu["Bread"] = 3.00m;
            menu["Coffee"] = 7.00m;
            menu["Banana"] = 0.50m;
            menu["Apple"] = 0.75m;

            

            PrintMenu(menu);

            //Let's add one item to the cart
            //cart.Add("Milk");
            //cart.Add("Apple");
            //cart.Add("Apple");

            bool doneAdding = false;
            while (!doneAdding)
            {

                Console.WriteLine("What would you like to buy?");
                string entry = Console.ReadLine();

                if (menu.ContainsKey(entry))
                {
                    Console.WriteLine($"An {entry} has been added to your cart for {menu[entry]}!");
                    cart.Add(entry);
                }
                else
                {
                    Console.WriteLine("We don't have that");


                }
                    
                    Console.WriteLine("Would you like to add another item?");
                    entry = Console.ReadLine();
                    if (entry == "N")
                    {
                        doneAdding = true;
                    }


                
            }


            PrintCart(cart, menu);


             





        }
    }
}
