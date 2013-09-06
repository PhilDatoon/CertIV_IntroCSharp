// Datoon, Philip Bryan B.
// 31 July 2013
// 131311399
// Using sequential search algorithm within a single dimensional array

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
            int[] arrayNum = { 10, 3, 9, 4, 8, 1, 7, 2, 6, 5 };

            Console.Write("Enter a number (1 to 10): ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Sequential search algorithm
            for (int i = 0; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] == target)
                {
                    Console.WriteLine(">> Number {0} is found. Located in array[{1}].", target, i);
                    break;      // stops searching and exits FOR loop
                }

                else
                {
                    Console.WriteLine("...");
                }
            }

            Console.Read();
        }
    }
}