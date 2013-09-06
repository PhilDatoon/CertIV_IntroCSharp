// Datoon, Philip Bryan B.
// 31 July 2013
// 131311399
// Using bubble sort algorithm

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
            int temp = 0;
            int sortNum = 1;

            // Bubble sort algorithm
            for (int i = 0; i < arrayNum.Length; i++)
                for (int k = i + 1; k < arrayNum.Length; k++)
                    if (arrayNum[i] > arrayNum[k])
                    {   
                        // displays arrayNum[] values before being compared or swapped
                        Console.Write("Sort {0} -- ", sortNum++);
                        for (int p = 0; p < arrayNum.Length; p++)
                            Console.Write("{0} ", arrayNum[p]);
                        // displays arrayNum[] values to be compared or swapped
                        Console.Write("-- comparing {0} and {1}", arrayNum[i], arrayNum[k]);

                        temp = arrayNum[i];
                        arrayNum[i] = arrayNum[k];
                        arrayNum[k] = temp;

                        Console.WriteLine();
                    }

            // displays bubble sorted array
            Console.Write("Sort {0} -- ", sortNum);
            for (int j = 0; j < arrayNum.Length; j++)
                Console.Write("{0} ", arrayNum[j]);
            Console.Write("<< This is the bubble sorted array.", sortNum);

            Console.Read();
        }
    }
}