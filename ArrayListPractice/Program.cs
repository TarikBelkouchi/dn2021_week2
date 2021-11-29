using System;
using System.Collections.Generic;

namespace ArrayListPractice
{
    class MainClass
    {
        public static List<string> CreateList(string first, string second, string third)
        {
            List<string> result = new List<string>();
            result.Add(first);
            result.Add(second);
            result.Add(third);
            return result;
        }

        public static void PrintList(List<string> mylist)
        {
            foreach (string item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        public static string GetLast(List<string> mylist)
        {
            int length = mylist.Count;
            return mylist[length - 1];
        }

        public static string GetArrayLast(string[] myarray)
        {
            int length = myarray.Length;
            return myarray[length - 1];
        }

        static void Plural(string[] myarray)
        {
            //Add an s to the end of each string in the array
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = myarray[i] + "s";
            }
                   
        }

        public static int Average(List<int> nums)
        {
            // example 3,4, 5
            //1. add them up to get 12
            //2.Divide them by 3 to get 4.
            int sum = 0;
            foreach (int item in nums)
            {
                sum += item;
            }

            return sum / nums.Count;
        }

        public static void Main(string[] args)
        {
            List<string> words = CreateList("apple", "banana", "cranberry");
            PrintList(words);
            Console.WriteLine("\nLet's get the last item");
            string last = GetLast(words);
            Console.WriteLine(last);

            Console.WriteLine("\nLet's get the last item from an array!");
            string[] morewords = new string[]("Fred", "Sally", "Julia");
            string namelast = GetArrayLast(morewords);
            Console.WriteLine(namelast);

            Console.WriteLine("\nPlurals");
            Plural(morewords);
            foreach (string name in morewords)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nAverage");
            List<int> mynumbers = new List<int>();
            mynumbers.Add(3);
            mynumbers.Add(4);
            mynumbers.Add(5);
            Console.WriteLine(Average(mynumbers));

        }
    }
}
