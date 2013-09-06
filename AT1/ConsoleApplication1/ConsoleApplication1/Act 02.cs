// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Place marking and pass variable

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
            Console.WriteLine("Please enter your Name : \n");   // user input name
            string UserName = Console.ReadLine();               // reads the value entered
            Console.WriteLine("Hello {0}", UserName);           // Place marking and pass variable

            Console.Read();                                     // pause program to read information
        }
    }
}