// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Using ternary operators

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
            Console.WriteLine("The If condition");
            Console.Write("Enter a number: ");              // user input Number
            int Number = int.Parse(Console.ReadLine());     // reads Number value entered

            // use of ternary operators
            // condition ? true statement : false statement
            bool IsNumber10 = Number == 10 ? true : false;
            
            // displays value either TRUE or FALSE
            Console.WriteLine("Number == 10 is {0}.", IsNumber10);
            
            // pause program to read information
            Console.Read();
        }
    }
}