// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// String concatenation

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
            Console.WriteLine("Hello C Sharp!\n");
            Console.WriteLine("Please enter your Name : \n");   // user input UserName
            string UserName = Console.ReadLine();               // reads the UserName input value
            Console.WriteLine("Hello " + UserName);             // String concatenation
            Console.Read();                                     // pause program to read information
        }
    }
}