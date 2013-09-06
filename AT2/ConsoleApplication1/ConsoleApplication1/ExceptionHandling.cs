// Datoon, Philip Bryan B.
// 29 July 2013
// 131311399
// Using exception handling on invalid user input data type

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
            int[] intArray = new int[3];            // declaring and initialising array
            intArray[0] = 0;
            intArray[1] = 0;
            intArray[2] = 0;

            Console.WriteLine("The Array loop");

            int attempts = 0;

            for (int k = 0; k < intArray.Length; k++)
            {
                try
                {
                    if (attempts == 2)
                    {   // displays when invalid input data type was entered on two attempts
                        Console.WriteLine("Please enter numbers 1 to 10");
                    }
                        
                    Console.Write("Please enter a number for element {0}: ", k + 1);
                    intArray[k] = int.Parse(Console.ReadLine());
                }

                // handles exception on invalid data type
                catch (Exception)
                {
                    Console.WriteLine("    >> Wrong data type");
                    k--;
                    attempts++;
                }
            }

            // display the array contents
            int i = 0;
            while (i < intArray.Length)
            {
                Console.WriteLine(intArray[i]);
                i++;
            }

            Console.Read();
        }
    }
}