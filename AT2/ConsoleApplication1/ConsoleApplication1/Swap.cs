// Datoon, Philip Bryan B.
// 31 July 2013
// 131311399
// Swapping or sorting two numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;
            Program bigger = new Program();

            Console.Write("Please enter first number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("First: {0}, Second: {1}", first, second);

            if (first > second)
                bigger.swap(ref first, ref second);         // calling swap() method

            Console.WriteLine("First: {0}, Second: {1}", first, second);

            Console.Read();
        }
    }
}