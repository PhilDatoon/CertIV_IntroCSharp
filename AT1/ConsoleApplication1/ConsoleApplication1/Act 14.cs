// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// Using WHILE loop and ITERATION

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
            Console.WriteLine("The WHILE construct");
            Console.WriteLine("Please enter a target number: ");

            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write("{0} ", Start);
                Start = Start + 2;              // use of iteration
            }

            // pauses program to read information
            Console.ReadLine();
        }
    }
}