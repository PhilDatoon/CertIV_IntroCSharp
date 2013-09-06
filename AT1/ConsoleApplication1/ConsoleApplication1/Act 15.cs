// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// Using DO-WHILE construct

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
            Console.WriteLine("The DO-WHILE construct");
            string UserChoice;

            // performs while user wants to continue to enter a new target number
            do
            { // Start of DO-WHILE
                Console.WriteLine("Please enter a target number: ");
                int UserTarget = int.Parse(Console.ReadLine());
                int Start = 0;

                while (Start <= UserTarget)
                {
                    Console.Write(Start + " ");
                    Start = Start + 2;
                }

                do  // asks user to continue to enter a new target number
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Do you want to continue? Yes or No?");
                    UserChoice = Console.ReadLine();

                    if (UserChoice != "Yes" && UserChoice != "No")
                    {
                        Console.WriteLine("\nInvalid choice. Enter Yes or No.");
                    }
                } while (UserChoice != "Yes" && UserChoice != "No");
            } while (UserChoice == "Yes"); // End of DO-WHILE

            // pauses program to read information
            Console.ReadLine();
        }
    }
}