// Datoon, Philip Bryan B.
// 29 July 2013
// 131311399
// Using single and multi-dimensional array within FOREACH loop

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
            // declaring and initialising single dimensional array (integer data type) 
            int[] intArray = new int[3];
            intArray[0] = 3;
            intArray[1] = 6;
            intArray[2] = 9;

            Console.WriteLine("===============");

            // displaying elements of intArray[]
            foreach (int i in intArray)
            {
                Console.WriteLine(i.ToString());
            }

            // declaring and initialising single dimensional array (string data type)
            string[] strArray = new string[5] { "Ronnie", "Jack", "Lori", "Max", "Tricky" };
            Console.WriteLine("===============");

            // displaying elements of strArray[]
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }

            // declaring and initialising multi dimensional array (string data type)
            string[,] names = new string[,] { { "Rosy", "Amy" }, { "Peter", "Albert" } };
            Console.WriteLine("===============");

            // displaying elements of names[,]
            foreach (string str in names)
            {
                Console.WriteLine(str);
            }
            
            Console.Read();
        }
    }
}