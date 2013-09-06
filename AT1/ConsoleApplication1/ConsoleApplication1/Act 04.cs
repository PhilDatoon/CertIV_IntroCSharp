// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Using mathematical operators

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
            Console.WriteLine("Divide");
            int Numerator = 11;                                     // declaration and initialisation of variables
            int Denominator = 2;

            int Result1 = Numerator / Denominator;                  // calculates the quotient
            int Result2 = Numerator % Denominator;                  // calculates the remainder

            Console.WriteLine("Quotient Result = {0}", Result1);    // displays the quotient
            Console.WriteLine("Remainder Result = {0}", Result2);   // displays the remainder

            Console.Read();                                         // pause program to read information
        }
    }
}