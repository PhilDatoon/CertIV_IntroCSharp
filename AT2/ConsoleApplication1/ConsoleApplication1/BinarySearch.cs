// Datoon, Philip Bryan B.
// 2 August 2013
// 131311399
// Using binary search algorithm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OneMethod
    {
        static void Main(string[] args)
        {
            int[] mynumbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int target = 0;
            int mid = 0;
            int first = 0;
            int last = mynumbers.Length - 1;

            Console.WriteLine("please enter search target");
            target = int.Parse(Console.ReadLine());

            //for a sorted array with descending values
            while (first < last)
            {
                mid = (first + last) / 2;
                if (target < mynumbers[mid])
                {
                    first = mid + 1;
                    Console.WriteLine("First {0}, Mid {1}", first, mid);
                }
                if (target > mynumbers[mid])
                    last = mid - 1;
                else
                {
                    Console.WriteLine("show output" + mynumbers[mid]);
                    break;
                }

            } // end of WHILE loop
            
            /*
            // Binary search algorithm
            while (first <= last)
            {
                mid = (first + last) / 2;

                if (target == mid)
                {
                    Console.Write("Found.");
                    break;
                }
                else if (target < mid)
                    last = mid - 1;
                else
                    first = mid + 1;
            }
            */
            Console.Read();
        }
    }
}