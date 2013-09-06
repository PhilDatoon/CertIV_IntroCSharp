// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// Using SWITCH-CASE statement

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
            { // Start of switch
                case 10: Console.WriteLine("Your number is 10.");   // performs if UserNumber == 10
                    break;                                          // exits SWITCH statement if UserNumber == 10
                case 20: Console.WriteLine("Your number is 20.");   // performs if UserNumber == 20
                    break;                                          // exits SWITCH statement if UserNumber == 20
                case 30: Console.WriteLine("Your number is 30.");   // performs if UserNumber == 30
                    break;                                          // exits SWITCH statement if UserNumber == 30
                default: Console.WriteLine("Your number is not 10, 20 or 30."); // performs if UserNumber is not equal to any of the above
                    break;                                          // exits SWITCH statement by default
            } // End of switch

            Console.ReadLine();     // pause program to read information
        } // End of main
    } // End of class
}