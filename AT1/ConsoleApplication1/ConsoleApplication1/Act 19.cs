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
            int[] EvenNumbers = { 0, 0, 0 };                    // declaring and initialising array

            for (int j = 0; j < EvenNumbers.Length; j++)
            {
                Console.Write("Please enter a number: ");       // user input for EvenNumbers[]
                EvenNumbers[j] = int.Parse(Console.ReadLine()); // reads EvenNumber[x] values entered
            }

            for (int k = 0; k < EvenNumbers.Length; k++)
            {
                Console.WriteLine(EvenNumbers[k]);              // displays elements of EvenNumbers[]
            }

            Console.Read();                                     // pauses program to read information
        }
    }
}