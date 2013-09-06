// Datoon, Philip Bryan B.
// 131311399
// 24 July 2013
// User input and displaying array contents

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
        { // Input array size
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] Array = new int[size];

            // Input array values
            Console.WriteLine();
            Console.Write("Enter {0} numbers into the array\n", size);
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Enter element {0} = ", i+1);
                Array[i] = int.Parse(Console.ReadLine());
            }

            // Displays the input
            Console.WriteLine();
            Console.Write("The numbers you entered are:\n");
            for (int j = 0; j < Array.Length; j++)
            {
                Console.WriteLine("Array[{0}] = {1}", j, Array[j]);
            }

            Console.Read();
        }
    }
}