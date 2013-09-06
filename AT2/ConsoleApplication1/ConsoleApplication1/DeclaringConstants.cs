// Datoon, Philip Bryan B.
// 26 July 2013
// 131311399
// Defining constants

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
            const double pi = 3.14159;                  // declaring constant variable
            double r;
            Console.WriteLine("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());   // converts input to double data type
            double areaCircle = pi * r * r;             // calculating areaCircle
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);

            Console.Read();
        }
    }
}