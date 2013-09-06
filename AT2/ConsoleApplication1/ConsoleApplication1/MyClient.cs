// Datoon, Philip Bryan B.
// 29 July 2013
// 131311399
// Using exception handling in dividing a number by zero

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyClient
    {
        static void Main(string[] args)
        {
            int x = 0;
            int div = 0;

            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed.");
            }
            // catches exceptions on dividing a number by zero
            catch (DivideByZeroException de)
            {
                Console.WriteLine("DivideByZeroException.");
            }
            // catches exceptions on invalid data type input
            catch (Exception ee)
            {
                Console.WriteLine("oException");
            }

            finally
            {
                Console.WriteLine("Finally block.");
            }
            
            Console.WriteLine("Result is {0}.", div);
            Console.Read();
        }
    }
}