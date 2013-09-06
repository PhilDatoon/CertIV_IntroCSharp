// Datoon, Philip Bryan B.
// 22 July 2013
// 131311399
// Using nested IF-ELSE statement

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
            Console.Write("Please enter a number: ");           // user input integer
            int UserNumber = int.Parse(Console.ReadLine());     // reads UserNumber value input

            // start of IF-ELSE statement
            // performs if integer is equal to 1
            if (UserNumber == 1)        
            {
                Console.WriteLine("The number is One >> {0}.", UserNumber);
            }
                // performs if integer is equal to 2
                else if (UserNumber == 2)
                {
                    Console.WriteLine("The number is Two >> {0}.", UserNumber);
                }
                // performs if integer is equal to 3
                else if (UserNumber == 3) 
                {
                    Console.WriteLine("The number is Three >> {0}.", UserNumber);
                }

            // performs if integer neither 1, 2, nor 3
            else
            {
                Console.WriteLine("Your number was NOT 1, 2, or 3.");
            }       // end of IF-ELSE statement

            // pause program to read information
            Console.Read();
        }
    }
}