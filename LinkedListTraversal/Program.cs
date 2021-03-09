using System;
using System.Collections.Generic;

namespace LinkedListTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requirement: Given a singularly linked list of integers, return the 5th integer from the end of the list using the most efficient method.

            // please type in your input here
            IList<int> testValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            try
            {
                Console.WriteLine(testValues[testValues.Count - 5]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("something goes wrong: " + ex);
            }
        }
    }
}
