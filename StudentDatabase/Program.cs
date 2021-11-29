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

            do
            {
                string entry = "";
                int num = 0;
                bool validEntry = false;
                do
                {

                    Console.WriteLine("Which student would you like information on another student?");
                    entry = Console.ReadLine();



                    num = int.Parse(entry);

                    if (num >= 1 && num <= 4)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1- 4.");
                    }

                } while (validEntry == false);


                Console.WriteLine(name[num]);


                validEntry = false;

                do
                {
                    Console.WriteLine("Which Category? Please entr hometown or favorite food:  ");
                    entry = Console.ReadLine();
                    if (entry == "hometown")
                    {
                        Console.WriteLine($"{name[num]} is from {homeTown[num]}.");
                        validEntry = true;
                    }
                    else if (entry == "favorite food")
                    {
                        Console.WriteLine($"{name[num]}'s favorite food is {favFood[num]}.");
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter hometown or favorite food: ");
                    }

                }
                while (validEntry == false);

            }
            while (GoAgain());

        }
    }
}





