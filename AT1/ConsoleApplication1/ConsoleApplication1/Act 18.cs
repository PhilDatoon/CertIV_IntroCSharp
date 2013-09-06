// Datoon, Philip Bryan B.
// 29 July 2013
// 131311399
// Different ways of declaring and initialising array

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
            int max = 3;
            int[] EvenNumbers = new int[3];         // declaration of array EvenNumbers
            int[] OddNumbers = {3, 5, 7};           // declaration and initialising array OddNumbers

            EvenNumbers[0] = 2;                     // initialising EvenNumbers[] elements
            EvenNumbers[1] = 4;
            EvenNumbers[2] = 6;

            // displays all elements of EvenNumbers[]
            for (int j = 0; j < max; j++)
            {
                Console.WriteLine(EvenNumbers[j]);
            }

            // displays all elements of OddNumbers[]
            for (int k = 0; k < max; k++)
            {
                Console.WriteLine(OddNumbers[k]);
            }

            // pauses program to read information
            Console.Read();
        }
    }
}