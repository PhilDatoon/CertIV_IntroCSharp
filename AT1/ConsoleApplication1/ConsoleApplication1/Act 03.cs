// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Multiple place markings and pass variables

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
            Console.WriteLine("Please enter your first name :");        // user input FirstName
            string FirstName = Console.ReadLine();                      // reads FirstName value entered
            Console.WriteLine("Please enter your last name :");         // user input LastName
            string LastName = Console.ReadLine();                       // reads LastName value entered
            Console.WriteLine("Hello {0}, {1}", FirstName, LastName);   // Multiple place markings and pass variables

            Console.Read();                                             // pause program to read information
        }
    }
}