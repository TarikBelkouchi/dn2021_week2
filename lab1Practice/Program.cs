using System;

namespace lab1Practice
{
    class MainClass
    {

        public static bool GoAgain()
        {
            while (true)
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

        }


          public static void Main(string[] args)
          {
                string[] names = new string[] { "Jeff", "Antonio", "Hanna", "Tommy" };
                string[] hometowns = new string[] { "Grand Rapids", "Detroit", "Seatle", "Raleigh" };
                string[] food = new string[] { "Pizza", "Foccia Bares", "Shrimp", "Chicken Dumplings" };
                
                
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

                        if (num >=1 && num <= 4)
                        {
                            validEntry = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number between 1- 4.");
                        }

                    } while (validEntry == false);


                    //We'll let the user start with 1 as the first, rather than actual index 0 as the first

                    //Name      Index   What user enters
                    //jeff      0       1
                    //antonio   1       2
                    //hanna     2       3
                    //tommy     3       4

                    num--; //this is how we let the user start at 1 instead of 0


                    Console.WriteLine(names[num]);


                validEntry = false;

                do
                {
                    Console.WriteLine("Which Category? Please entr hometown or favorite food:  ");
                    entry = Console.ReadLine();
                    if (entry == "hometown")
                    {
                        Console.WriteLine($"{names[num]} is from {hometowns[num]}.");
                        validEntry = true;
                    }
                    else if (entry == "favorite food")
                    {
                        Console.WriteLine($"{names[num]}'s favorite food is {food[num]}.");
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

