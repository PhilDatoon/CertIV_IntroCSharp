// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Using IF-ELSE statement

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
            Console.WriteLine("is equal \n");
            Console.Write("Enter a number: ");              // User input Number
            int Number = int.Parse(Console.ReadLine());     // reads Number value entered
            
            // Start of IF-ELSE statement
            // performs if number is greater than 10
            if (Number > 10)
            {
                Console.WriteLine("The variable number is greater than 10.");
            }
            // performs if number is lesser than 10
            else
            {
                Console.WriteLine("The variable number is lesser than 10.");
            }
            // End of IF-ELSE statement

            // pause program to read information
            Console.Read();
        }
    }
}