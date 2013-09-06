// Datoon, Philip Bryan B.
// 26 July 2013
// 131311399
// Using class and methods (main class is located in MainProject.cs)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NumberManipulator
    {
        // FindMax() method - finds the higher integer entered
        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        // FindMin() method - finds the lower integer entered
        public int FindMin(int num1, int num2)
        {
            int result;

            if (num1 < num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        // Read() method - reads or returns integers entered 
        public int Read(int num)
        {
            return num;
        }

        // FindSum() method - calculates the sum of two integers entered
        public int FindSum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }

        // FindDiff() method - calculates the difference between two integers entered
        public int FindDiff(int num1, int num2)
        {
            int diff = num1 - num2;

            return diff;
        }

        // Abs() method- returning the absolute value of the integers entered
        public int Abs(int num1)
        {
            int absoluteValue = num1;

            if (num1 < 0)
                absoluteValue = num1 * -1;

            return absoluteValue;
        }
    }
}
