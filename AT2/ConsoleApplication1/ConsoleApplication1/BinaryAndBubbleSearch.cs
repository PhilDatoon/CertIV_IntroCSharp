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
    class Program
    {
        void ArrayData(int[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            { //Display array contents
                Console.Write("-{0}", Numbers[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Numbers.Length; i++)
            { //Display array index
                Console.Write("- {0} ", i);
            }
            Console.WriteLine();
        } //end of ArrayData

        static void Main(string[] args)
        {
            int[] SearchArray = new int[10];
            int target = 0; // value to find
            int midpoint = 0;
            int first = 0;  //first value in array
            int last = SearchArray.Length - 1; // last value in array
            bool OK = false;
            Program Display = new Program();
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // initialising SearchArray[] values using Random.next()
            Random random = new Random();
            for (int p = 0; p < SearchArray.Length; p++)
                SearchArray[p] = random.Next(100, 500);
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            int i = 0, j = 0, temp = 0;
            // Sorting: Bubble Sort
            for (i = 0; i < SearchArray.Length; i++)
            {
                for (j = i + 1; j < SearchArray.Length; j++)
                {
                    if (SearchArray[i] > SearchArray[j])
                    {
                        temp = SearchArray[i];
                        SearchArray[i] = SearchArray[j];
                        SearchArray[j] = temp;
                    }
                    Display.ArrayData(SearchArray);
                    Console.WriteLine("J={0}", j);
                }
                Console.WriteLine("I={0}", i);
            }
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            do //get target integer from keyboard
            {
                Console.WriteLine("Please enter search target (between 100 - 500): ");
                target = int.Parse(Console.ReadLine());
                if (target >= 100 && target <= 500)
                    OK = true;
            }
            while (!OK); //end of Do While loop
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //search a sorted array with ascending values
            while (first <= last)
            {
                midpoint = (first + last) / 2; //find midpoint of array
                if (target == SearchArray[midpoint])
                {
                    Console.WriteLine("The target has been found at {0} with a value of {1}",                                                     midpoint , SearchArray[midpoint]);
                    Display.ArrayData(SearchArray);
                    break;
                }                                
                else if (target < SearchArray[midpoint])
                         last = midpoint - 1;
                     else 
                         first = midpoint + 1;

            } //end of while loop

            Console.Read();
        }
    }
}