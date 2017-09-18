using System;
using System.Collections.Generic;

namespace OddFilter
{
    class Program
    {
        static List<int> OddFilter (List<int> oddElements)
        {
            for ( int i = 0 ; i < oddElements.Count ; i++ )
            {
                if (oddElements[i] % 2 == 0)
                {
                    oddElements.Remove(oddElements[i]);
                }
            }

            return oddElements;
        }

        private static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });

            // In case of the example input above, the given PrintList function should print 1 3 5 
            PrintList(oddElements);

            Console.ReadLine();
        }
    }
}