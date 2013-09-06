// Datoon, Philip Bryan B.
// 5 August 2013
// 131311399
// PROJECT: Part 2

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
            const int max = 3; // max size of arrays

            // declaration of variables
            int[] bikeID = new int[max];
            int[] bikeSpeed = new int[max];
            String[] bikeColor = new String[max];
            String[] bikeYear = new String[max];
            String myChoice;

            ProgramBike bike = new ProgramBike();

            bike.Initialise(bikeID, bikeSpeed, bikeColor, bikeYear, max);

            do
            {
                // calls getChoice() method and gets the value returned to myChoice variable
                myChoice = bike.getChoice();

                switch (myChoice)
                {
                    case "1":
                        // calls Display() method to display all records when "1" key is pressed
                        bike.Display(bikeID, bikeSpeed, bikeColor, bikeYear, max);
                        break;
                    case "2":
                        // calls AddDetails() method to ask user full record when "2" key is pressed
                        bike.AddDetails(bikeID, bikeSpeed, bikeColor, bikeYear, max);
                        break;
                    case "3":
                        // calls ModifyDetails() method to let user modify a record when "3" key is pressed
                        bike.ModifyDetails(bikeID, bikeSpeed, bikeColor, bikeYear, max);
                        break;
                    case "Q":
                    case "q":
                        // displays when user pressed "q" or "Q" to quit program
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        // default display once a choice was not met or invalid
                        Console.WriteLine("{0} is not a valid choice.", myChoice);
                        break;
                }

                // pauses to allow user see the results
                Console.WriteLine();
                Console.Write("Press enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();

                // program still executes unless user presses "q" or "Q" key to quit
            } while (myChoice != "Q" && myChoice != "q");
        }   // end of main

        string getChoice()
        {
            string myChoice;

            // prints a menu
            Console.WriteLine(" +--------- M E N U ---------+");
            Console.WriteLine(" |   1 - Display array       |");
            Console.WriteLine(" |   2 - Enter full data     |");
            Console.WriteLine(" |   3 - Modify one record   |");
            Console.WriteLine(" |   Q - Quit                |");
            Console.WriteLine(" +---------------------------+");
            Console.WriteLine();
            Console.Write("Enter choice (1, 2, 3, or Q): ");

            // retrieves the user's choice
            myChoice = Console.ReadLine();
            Console.WriteLine();

            // returns user input to the main program
            return myChoice;
        }

        public void Initialise(int[] id, int[] speed, String[] color, String[] year, int max)
        {   // initialisation of arrays
            for (int i = 0; i < max; i++)
            {
                id[i] = i + 1;
                speed[i] = 0;
                color[i] = "";
                year[i] = "1900";
            } // end of initialisation of arrays
        }

        public void AddDetails(int[] id, int[] speed, String[] color, String[] year, int max)
        {
            ProgramBike add = new ProgramBike();

            Console.WriteLine("YOU HAVE CHOSEN TO ADD FULL DETAILS.");
            Console.WriteLine();

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Enter details for bike {0}: ", i + 1);

                // start of error trap - AddDetails()
                try
                {
                    speed[i] = add.GetSpeed();   // calls GetSpeed() method
                    color[i] = add.GetColor();   // calls GetColor() method
                    year[i] = add.GetYear();     // calls GetYear() method
                }

                catch (Exception)
                {   // catches exceptions on invalid data type entered
                    Console.Write("ERROR: Wrong data type. ");
                    i--;
                } // end of error trap - AddDetails()

                Console.WriteLine();
            }
        }

        public int GetSpeed()
        {   // gets the top speed as an integer
            ProgramBike speed = new ProgramBike();
            int topSpeed;

            Console.Write("What is the top speed? ");
            topSpeed = int.Parse(Console.ReadLine());

            return topSpeed;
        }

        public String GetColor()
        {   // gets the bike colour as a string
            String color = String.Empty;

            do
            {
                Console.Write("What is the colour? ");
                color = Console.ReadLine();
                
                // error trap - does not allow user to enter null value
                if (color == "")
                    Console.Write("Input a color. ");

            } while (color == String.Empty);
            
            return color;

        }

        public String GetYear()
        {   // gets the bike manufacture as string
            String year = String.Empty;
            Boolean isValid = false;

            do
            {   // continues while user input is not valid
                Console.Write("What is the year of manufacture? ");
                year = Console.ReadLine();

                // error trap - does not allow user to enter null value
                if (year == "")
                {
                    Console.Write("ERROR: Input a year. ");
                    isValid = false;
                }

                else
                {   // start of error trap -- for conversion of String to int
                    try
                    {   // only accept year values between 1900 and 2013
                        // uses String to int conversion to check if it is valid
                        if (Convert.ToInt32(year) < 1900 || Convert.ToInt32(year) > 2013)
                        {
                            Console.WriteLine("ERROR: Invalid year. Must be between 1900 and 2013. ");
                            isValid = false;
                        }

                        else if (Convert.ToInt32(year) >= 1900 && Convert.ToInt32(year) <= 2013)
                            isValid = true;
                    }
                    
                    catch (Exception)
                    {   // catches exceptions on invalid data type entered
                        // then calls GetYear() method
                        Console.WriteLine("ERROR: Invalid year. Must be between 1900 and 2013. ");
                        GetYear();
                    } // end of error trap
                }
            } while (!isValid);

            return year;
        }

        public void ModifyDetails(int[] id, int[] speed, String[] color, String[] year, int max)
        {
            ProgramBike modify = new ProgramBike();

            int recordNum;
            Boolean isErrorExisting = false;

            Console.WriteLine("YOU HAVE CHOSEN TO MODIFY A RECORD.");
            Console.WriteLine();

            do
            {
                // gets record number the user wants to be modified
                Console.Write("Enter ID of the record to be modified (1 to {0}): ", max);
                recordNum = int.Parse(Console.ReadLine());
                
                // does not allow user to enter record number 
                if (recordNum < 1 || recordNum > max)
                    Console.Write("ERROR: ID #{0} not found. ", recordNum);

            } while (!(recordNum > 0 && recordNum <= max));

            Console.WriteLine();
            Console.WriteLine("Enter new details for bike {0}: ", recordNum);

            do
            {
                try
                {
                    speed[recordNum - 1] = modify.GetSpeed();   // calls GetSpeed() method
                    color[recordNum - 1] = modify.GetColor();   // calls GetColor() method
                    year[recordNum - 1] = modify.GetYear();     // calls GetYear() method
                    isErrorExisting = true;
                }

                catch (Exception)
                {   // catches exceptions on invalid data type entered
                    Console.Write("ERROR:  Wrong data type. ");
                } // end of error trap

            } while (!isErrorExisting);

            Console.WriteLine();
        }

        public void Display(int[] id, int[] speed, String[] color, String[] year, int max)
        {
            Console.WriteLine("YOU HAVE CHOSEN TO DISPLAY RECORDS.");
            Console.WriteLine();
            
            // displays all the values of the elements of the arrays
            for (int i = 0; i < max; i++)
                Console.WriteLine(" ID # {0} \t top speed: {1} \t color: {2} \t made in year: {3}",
                    id[i], speed[i], color[i], year[i]);
        }
    }
}