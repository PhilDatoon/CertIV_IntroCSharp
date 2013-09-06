// Datoon, Philip Bryan B.
// 2 August 2013
// 131311399
// Developing an application with series of loops and methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ProgramBike
    {
        static void Main(string[] args)
        {
            const int max = 3;      // max size of arrays

            int[] bikeID = new int[max];
            int[] bikeSpeed = new int[max];
            String[] bikeColor = new String[max];
            String[] bikeYear = new String[max];

            ProgramBike Vspeed = new ProgramBike();
            ProgramBike Vcolor = new ProgramBike();
            ProgramBike Vyear = new ProgramBike(); 
            ProgramBike values = new ProgramBike();

            // initialisation of arrays
            for (int i = 0; i < max; i++)
            {
                bikeID[i] = 0;
                bikeSpeed[i] = 0;
                bikeColor[i] = "";
                bikeYear[i] = "1900";
            }
            
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Enter details for bike {0}: ", i + 1); 
                
                try
                {
                    bikeID[i] = i;
                    bikeSpeed[i] = Vspeed.GetSpeed();
                    bikeColor[i] = Vcolor.GetColor();
                    bikeYear[i] = Vyear.GetYear();

                    Console.WriteLine();
                }

                catch (Exception)
                {
                    Console.Write(">> Wrong data type. ");
                    i--;
                }
            }

            for (int i = 0; i < max; i++)
            {
                values.Display(bikeID[i], bikeSpeed[i], bikeColor[i], bikeYear[i]);
            }

            Console.Read();
        }   // end of main

        public int GetSpeed()
        {   // gets the top speed as an integer
            int topspeed;
            Console.Write("What is the top speed? ");
            topspeed = int.Parse(Console.ReadLine());
            return topspeed;     
        }

        public String GetColor()
        {   // gets the bike colour as a string
            String color = String.Empty;
            do
            {
                Console.Write("What is the colour? ");
                color = Console.ReadLine();
            
                if (color == "")
                    Console.Write("Input a color. ");

            } while (color == String.Empty);

            return color;
        }

        public String GetYear()
        {   // gets the bike manufacture as string
            String year = String.Empty;
            do
            {
                Console.Write("What is the year of manufacture? ");
                year = Console.ReadLine();

                if (year == "")
                    Console.Write("Input a year. ");

            } while (year == String.Empty);

            return year;
        }
                
        public void Display(int id, int speed, String color, String year)
        {
            Console.WriteLine("ID# {0} \t top speed: {1} \t color: {2} \t made in year: {3}.",
                id, speed, color, year);
        }


    }
}