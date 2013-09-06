// Datoon, Philip Bryan B.
// 26 July 2013
// 131311399
// Calling another method within a method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rectangle         // Start of class Rectangle
    {   
        double length;
        double width;

        // initialises the value of length and width
        public void AcceptDetails(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        // calculates the area of the rectangle
        public double GetArea()
        {
            return length * width;
        }

        // displays the values of length, width, and area of the rectangle
        public void Display()
        {
            Console.WriteLine("Length: {0}", Read(length));     // calling Read() method for length
            Console.WriteLine("Width: {0}", Read(width));       // calling Read() method for width
            Console.WriteLine("Area: {0}", GetArea());          // calling GetArea() method for area
        }

        // reads and returns the value passed into this method
        public double Read(double num)
        {
            return num;
        }
    }                       // End of class Rectangle

    class ExecuteRectangle  // Start of class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            // declaring an object
            Rectangle r = new Rectangle();

            // user inputs length of the rectangle
            Console.Write("Enter length of the rectangle: ");
            double lengthR = double.Parse(Console.ReadLine());

            // user inputs width of the rectangle
            Console.Write("Enter width of the rectangle: ");
            double widthR = double.Parse(Console.ReadLine());

            r.AcceptDetails(lengthR, widthR);           // calling AcceptDetails() method
            r.Display();                                // calling Display() method
            Console.Read();                             // pausing program to read information
        }
    }                       // End of class ExecuteRectangle
}