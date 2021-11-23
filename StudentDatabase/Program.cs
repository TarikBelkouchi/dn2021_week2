using System;

namespace StudentDatabase
{
    class MainClass
    {
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

            Console.WriteLine("Would you like learn about another student?");
            string entry = Console.ReadLine();


            if (entry.ToLower() == "n")
            {
                return false;
            }
            if (entry.ToLower() == "y")
            {
                return true;
            }
            else 
            {
                Console.WriteLine("Not a valid answer!");
                return false;
            }

            

        }





            public static void Main(string[] args)
        {

            


            string[] name = new string[] { "James", "Tommy", "Kanan", "Tasha" };
            string[] homeTown = new string[] { "New York", "Chicago", "Detroit", "Los Angeles" };
            string[] favFood = new string[] { "Pasta", "Pizza", "Burgers", "Shrimp" };

            Console.WriteLine("Welcome! Which student would you like to learn more about ? Enter a number 1 - 4:");

            string EntryNumber = Console.ReadLine();
            int entryNumber = int.Parse(EntryNumber);
          
            if (entryNumber == 1)
            {
                Console.WriteLine($"Student 1 is {name[0]}. What would you like to know? Enter 'hometown' or 'favorite food':");
            }
            if (entryNumber == 2)
            {
                Console.WriteLine($"Student 2 is {name[1]}. What would you like to know? Enter 'hometown' or 'favorite food':");
            }
            if (entryNumber == 3)
            {
                Console.WriteLine($"Student 3 is {name[2]}. What would you like to know? Enter 'hometown' or 'favorite food':");
            }
            if (entryNumber == 4)
            {
                Console.WriteLine($"Student 4 is {name[3]}. What would you like to know? Enter 'hometown' or 'favorite food':");
            }
            if (entryNumber >1 && entryNumber > 4)
            {
                Console.WriteLine("Not a valid selection.");
            }


            string entry2 = Console.ReadLine();
            if (entry2.ToLower() == "hometown")
            {
                return homeTown;
            }





        }
    }
}
