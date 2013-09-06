// Datoon, Philip Bryan B.
// 29 July 2013
// 131311399
// Using array and assigning values to its elements through user input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring and initialising array
            int[] EvenNumbers = { 0, 0, 0 };

            Console.WriteLine("Data entry for array size three (3)");

            // user input for each array element
            for (int j = 0; j < EvenNumbers.Length; j++)
            {
                Console.Write("Please enter a number for element {0}: ", j + 1);
                EvenNumbers[j] = int.Parse(Console.ReadLine());
            }

            // displays elements of EvenNumbers[]
            for (int k = 0; k < EvenNumbers.Length; k++)
            {
                Console.WriteLine("The value in element {0} is {1}.", k + 1, EvenNumbers[k]);
            }

            // pauses program to read information
            Console.Read();
        }
    }
}