// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Using OR operator

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
            Console.WriteLine("The If statement\n");
            Console.Write("Please enter a number: ");
            int UserNumber = int.Parse(Console.ReadLine()); // reads UserNumber value entered

            if (UserNumber == 10 || UserNumber == 20)       // using OR operator
            {
                Console.WriteLine("The number is 10 or 20 >> {0}.", UserNumber);
            }

            else
            {
                Console.WriteLine("The number is NOT 10 or 20. It was {0}.", UserNumber);
            }

            // pauses program to read information
            Console.Read();
        }
    }
}