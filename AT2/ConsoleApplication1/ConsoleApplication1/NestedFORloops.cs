// Datoon, Philip Bryan B.
// 26 July 2013
// 131311399
// Using interface loops

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
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break;                // if factor found, not a prime

                if (j > (i / j))
                    Console.WriteLine("{0} is prime.", i);  // displays if number is a prime
            }

            Console.Read();                                 // pause program to read information
        }
    }
}