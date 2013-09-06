// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// Using SWITCH-CASE statement (shorter version of Activity 12.cs)

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
            Console.WriteLine("The CASE or SWITCH statement\n");
            Console.WriteLine("Please enter a number: ");

            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            { // Start of SWITCH-CASE statement
                case 10:
                case 20:
                case 30: Console.WriteLine("Your number is {0}.", UserNumber);  // executes if Usernumber is either 10, 20, or 30
                    break;
                default: Console.WriteLine("Your number is not 10, 20 or 30.");
                    break;
            } // End of SWITCH-CASE statement

            // pauses program to read information
            Console.ReadLine();
        } // End of main
    } // End of class
}