// Datoon, Philip Bryan B.
// 31 July 2013
// 131311399
// Applying sorting algorithm in a multi-dimensional array

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
            int[,] arr = { { 20, 9, 11 }, { 30, 5, 6 }, { 10, 8, 2 } };
            
            Console.WriteLine("Before");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }

                Console.WriteLine();
            }

            // Start of array sorting algorithm
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1) - 1; j > 0; j--)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1])
                        {
                            int temp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }
            // End of array sorting algorithm

            // display sorted multi-dimensional array
            Console.WriteLine("After");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,5}", arr[i, j]);

                Console.WriteLine();
            }
            
            Console.Read();
        }
    }
}