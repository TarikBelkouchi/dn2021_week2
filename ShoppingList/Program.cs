using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class MainClass
    {

        public static void PrintMenu(Dictionary<string, decimal> menu)
        {
            Console.WriteLine("Welcome to the Store!");
            foreach (var pair in menu)
            {
                Console.WriteLine($"{ pair.Key} {pair.Value}");
            }

        }

        public static void PrintCart(List<string> cart, Dictionary<string, decimal> menu)
        {
            decimal sum = 0.00m;
            Console.WriteLine("here are your items!");
            foreach (string item in cart)
            {
                Console.WriteLine($"{item} price{menu[item]}");
                //sum = sum + menu[item];
                sum += menu[item];

            }
            Console.WriteLine($"Your total is {sum}.");
        }


        public static void Main(string[] args)
        {
     
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            List<string> cart = new List<string>();

            
            menu["apple"] = 0.99m;
            menu["banana"] = 0.59m;
            menu["cauliflower"] = 1.59m;
            menu["dragonfruit"] = 2.19m;
            menu["Elderberry"] = 1.79m;
            menu["figs"] = 2.09m;
            menu["grapfruit"] = 1.99m;
            menu["honeydew"] = 3.49m;



            PrintMenu(menu);

 

            bool doneAdding = false;
            while (!doneAdding)
            {

                Console.WriteLine("What item would you like to order");
                string entry = Console.ReadLine();

                if (menu.ContainsKey(entry))
                {
                    Console.WriteLine($"Adding{entry} to your order for {menu[entry]}!");
                    cart.Add(entry);
                }
                else
                {
                    Console.WriteLine("We don't have that");


                }

                Console.WriteLine("Would you like to order anything else?");
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
