// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// Using FOREACH, FOR, and WHILE loop

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
        {   // declaration of array Number[]
            int[] Numbers = new int[3];
            // initialisation of Number[] elements
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            Console.WriteLine("The FOREACH loop");

            // start of FOREACH loop
            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }   // end of FOREACH loop

            Console.WriteLine("\nThe FOR loop");
            // start of FOR loop
            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }   // end of FOR loop

            Console.WriteLine("\nThe WHILE loop");
            // start of WHILE loop
            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }   // end of WHILE loop

            // pauses program to read information
            Console.ReadLine();
        }
    }
}