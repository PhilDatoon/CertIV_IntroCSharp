// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Using BOOLEAN variable and IF-ELSE statement

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
            Console.WriteLine("The IF condition");
            Console.Write("Enter a number: ");              // user input Number
            int Number = int.Parse(Console.ReadLine());     // reads Number value entered

            // declaration of BOOLEAN variable
            bool IsNumber10;
            
            // start of IF-ELSE statement
            // performs if integer is equal to 10
            if (Number == 10)
            {
                IsNumber10 = true;
            }
            // performs if integer is NOT equal to 10
            else
            {
                IsNumber10 = false;
            }
            // end of IF-ELSE statement

            // displays result either TRUE or FALSE
            Console.WriteLine("Number == 10 is {0}.", IsNumber10);

            // pause program to read information
            Console.Read();
        }
    }
}