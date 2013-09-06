// Datoon, Philip Bryan B.
// 7 August 2013
// 131311399
// PROJECT: Part 1

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
            int max = 10;                   // holds the size of the array
            int[] myArray = new int[max];   // holds the array elements

            Program array = new Program();

            String myChoice;

            // calls InitialiseArray() method
            array.InitialiseArray(myArray, max);

            do
            {   // displays current values of the array
                Console.Write("Current values of the array are: ");
                array.DisplayArray(myArray, max);
                Console.WriteLine("\n");

                // calls getChoice() method and gets the value returned to myChoice variable
                myChoice = array.getChoice();

                switch (myChoice)
                {
                    case "1":
                        // calls DisplayArray() method
                        array.DisplayArray(myArray, max);
                        Console.WriteLine();
                        break;
                    case "2":
                        // calls SequentialSearch() method
                        array.SequentialSearch(myArray, max);
                        break;
                    case "3":
                        // calls BubbleSort() method
                        array.BubbleSort(myArray, max);
                        break;
                    case "4":
                        // calls BinarySearch() method
                        array.BinarySearch(myArray, max);
                        break;
                    case "5":
                        // calls ChangeElement() method
                        array.ChangeElement(myArray, max);
                        break;
                    case "Q":
                    case "q":
                        // displays when user pressed "q" or "Q" to quit program
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        // default display once a choice was not met or invalid
                        Console.WriteLine("ERROR: {0} is not a valid choice.", myChoice);
                        break;
                }
                
                // pauses to allow user see the results
                Console.WriteLine();
                Console.Write("Press enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();

                // program still executes unless user presses "q" or "Q" key to quit
            } while (myChoice != "Q" && myChoice != "q");

            Console.Read();
        }

        string getChoice()
        {
            string myChoice;

            // prints a menu
            Console.WriteLine(" +--------- M E N U ---------+");
            Console.WriteLine(" |   1 - Display array       |");
            Console.WriteLine(" |   2 - Sequential search   |");
            Console.WriteLine(" |   3 - Bubble sort         |");
            Console.WriteLine(" |   4 - Binary search       |");
            Console.WriteLine(" |   5 - Modify element      |");
            Console.WriteLine(" |   Q - Quit                |");
            Console.WriteLine(" +---------------------------+");
            Console.WriteLine();
            Console.Write("Enter choice (between 1 and 5, or Q): ");
            
            // retrieves the user's choice
            myChoice = Console.ReadLine();
            Console.WriteLine();

            // returns user input to the main program
            return myChoice;
        }

        void InitialiseArray(int[] num, int max)
        {   // initialising myArray[] contents using Random()
            Random random = new Random();

            for (int x = 0; x < max; x++)
                num[x] = random.Next(10, 50);   // assigns random numbers between 10 and 50
        }

        void DisplayArray(int[] num, int max)
        {   // displays all of the array elements
            for (int x = 0; x < max; x++)
                Console.Write("{0} ", num[x]);
        }

        public int GetInt()
        {
            Boolean OK = false; // sets flag once proper values entered
            int userInput;
            Program array = new Program();

            // start of error trap - userInput variable
            try
            {
                do
                {   // gets integer from user input
                    Console.Write("Enter an integer between 10 and 50: ");
                    userInput = int.Parse(Console.ReadLine());

                    // checks whether input is between 10 and 50 or not
                    if (userInput >= 10 && userInput <= 50)
                        OK = true;

                    else
                        Console.WriteLine("ERROR: The value is not between 10 and 50. ");

                } while (!OK);      // end of DO-WHILE loop
            }
            
            catch (Exception)
            {   // catches exceptions on invalid data type entered
                // GetInt() method itself will be called
                Console.WriteLine("ERROR: Wrong data type.\n");
                array.GetInt();
                throw;      // re-throws exception
            }   // end of error trap - userInput variable

            return userInput;   // returns valid user input
        }

        void SequentialSearch(int[] num, int max)
        {   // searches an item using sequential search algorithm
            int target = 0;             // hold value to search
            Boolean found = false;      // sets flag for sequential search
            Program array = new Program();

            // start of error trap - target variable
            try
            {
                Console.WriteLine("SEQUENTIAL SEARCH");
                Console.Write("Enter target: ");
                target = int.Parse(Console.ReadLine()); // gets target from user input

                if (target < 10 || target > 50)
                    Console.WriteLine("ERROR: The value is not between 10 and 50. ");
            }

            catch (Exception)
            {   // catches exceptions on invalid data type entered
                // SequentialSearch() method itself will be called
                Console.WriteLine("ERROR: Wrong data type.\n");
                array.SequentialSearch(num, max);
            }   // end of error trap - target variable

            for (int x = 0; x < max; x++)
            {
                if (target == num[x])
                {   // displays once value is found, then break the loop
                    Console.WriteLine("> The value has been found in array[{0}].", x);
                    found = true;
                    break;
                }

                if (!found)
                    // displays every time values is not equal to the element or is not found
                    Console.WriteLine("  The value has not been found.");
            }
        }

        void BubbleSort(int[] num, int max)
        {   // sorts the elements in ascending order using binary search algorithm
            Program array = new Program();
            int temp = 0;       // holds temporary values
            int sortNum = 1;    // holds number of sorting iterations executed

            Console.WriteLine("BUBBLE SORT");
            for (int x = 0; x < max; x++)
                for (int y = x + 1; y < max; y++)
                    if (num[x] > num[y])
                    {
                        // displays arrayNum[] values before swapping by calling DisplayArray() method
                        Console.Write("Sort {0} -- ", sortNum++);
                        array.DisplayArray(num, max);

                        // displays arrayNum[] values to be compared or swapped
                        Console.Write("-- swapping {0} and {1}", num[x], num[y]);

                        // swaps two integers
                        temp = num[x];
                        num[x] = num[y];
                        num[y] = temp;

                        Console.WriteLine();
                    }

            // displays bubble sorted array by calling DisplayArray() method
            Console.Write("Sort {0} -- ", sortNum);
            array.DisplayArray(num, max);
            Console.Write("-- the bubble sorted array", sortNum);
        }

        void BinarySearch(int[] num, int max)
        {
            int target = 0;                 // holds value to search
            Boolean binaryFound = false;    // sets flag for binary search
            int midpoint = 0;               // uses to hold value for midpoint of array
            int first = 0;                  // uses to hold first value in array
            int last = max - 1;             // uses to hold last value in array
            Program array = new Program();
            Console.WriteLine();

            // start of error trap
            try
            {
                Console.WriteLine("BINARY SEARCH ");
                Console.Write("Enter target: ");
                target = int.Parse(Console.ReadLine()); // gets target from user input

                while (first <= last)
                {
                    midpoint = (first + last) / 2;  // finds midpoint of the array

                    if (target == num[midpoint])
                    {   // checks to see if target is found, then breaks the loop
                        Console.WriteLine("The target \"{0}\" has been found in array[{1}].", target, midpoint);
                        binaryFound = true;
                        break;
                    }

                    else if (target < num[midpoint])    // divides array into half
                        last = midpoint - 1;            // keeps checking for the target

                    else
                        first = midpoint + 1;
                }

                if (!binaryFound)
                    // displays when value is not located in array
                    Console.WriteLine("The value has not been found.");
            }

            catch (Exception)
            {   // catches exceptions on invalid data type entered for target variable,
                // BinarySearch () method itself will be called */
                Console.WriteLine("ERROR: Wrong data type. Enter target again.\n");
                array.BinarySearch(num, max);
            } // end of error trap
        }

        void ChangeElement(int[] num, int max)
        {
            int changeIndex = 0;    // holds the index of the element to modify
            Boolean OK = false;     // sets flag for element number check
            Program array = new Program();
            Console.WriteLine();

            
            do
            {   
                // start of error trap - changeIndex variable
                try
                { 
                    // gets element index to change from user input
                    Console.Write("What element do you want to modify (0 to {0})?", max);
                    changeIndex = int.Parse(Console.ReadLine());

                    // checks whether input is within the length of the array or not
                    if (changeIndex >= 0 && changeIndex < (max - 1))
                        OK = true;

                    else
                        Console.WriteLine("ERROR: The value is not between 0 and {0}.", (max - 1));
                }

                catch (Exception)
                {   /* catches exceptions on invalid data type entered,
                 * ChangeElement() method itself will be called */
                    Console.WriteLine("ERROR: Wrong data type. Enter target again.\n");
                    array.ChangeElement(num, max);
                } // end of error trap - changeIndex variable

             } while (OK == false);
            
            Console.WriteLine("Enter the new value for element {0}.", changeIndex);
            num[changeIndex] = GetInt();    // calls GetInt() method
        }
    }
}