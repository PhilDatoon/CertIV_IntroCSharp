// Datoon, Philip Bryan B.
// 26 July 2013
// 131311399
// Calling methods (NumberManipulator class and methods are in NumberManipulator.cs file)

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
        {   // declaration of object
            NumberManipulator n = new NumberManipulator();
            int ret;

            // User input for integer 1
            Console.Write("Enter integer 1: ");
            int c = int.Parse(Console.ReadLine());

            // User input for integer 2
            Console.Write("Enter integer 2: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Calling FindMax() method - finds the higher integer entered
            ret = n.FindMax(c, d);
            Console.WriteLine("Max value is: {0}", ret);

            // Calling FindMin() method - finds the lower integer entered
            ret = n.FindMin(c, d);
            Console.WriteLine("Min value is: {0}", ret);

            Console.WriteLine();

            // Calling Read() method - reads or returns integers entered 
            ret = n.Read(c);
            Console.WriteLine("Integer 1 is: {0}", ret);
            ret = n.Read(d);
            Console.WriteLine("Integer 2 is: {0}", ret);

            Console.WriteLine();

            // Calling FindSum() method - calculates the sum of two integers entered
            ret = n.FindSum(c, d);
            Console.WriteLine("The sum of the integers is: {0}", ret);

            // Calling FindDiff() method - calculates the difference between two integers entered
            ret = n.FindDiff(c, d);
            Console.WriteLine("The difference between the integers is: {0}", ret);

            Console.WriteLine();

            // Calling Abs() method - returning the absolute value of the integers entered
            ret = n.Abs(c);
            Console.WriteLine("The absolute value of {0} is: {1}", c, ret);
            ret = n.Abs(d);
            Console.WriteLine("The absolute value of {0} is: {1}", d, ret);

            // Pausing program to read information
            Console.Read();
        }
    }
}