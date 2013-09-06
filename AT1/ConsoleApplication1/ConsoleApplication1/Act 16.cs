// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// Using arrays and WHILE loop

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
            // declaration of arrays Numbers[] and Odd[]
            int[] Numbers = new int[3];
            int[] Odd = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            Odd[0] = 3;
            Odd[1] = 5;
            Odd[2] = 7;

            int i = 0;

            // start of WHILE loop - displays the elements of arrays Numbers[] and Odd[]
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                Console.WriteLine(Odd[i]);
                i++;
            }   // end of WHILE loop

            // pauses program to read information
            Console.ReadLine();
        }
    }
}