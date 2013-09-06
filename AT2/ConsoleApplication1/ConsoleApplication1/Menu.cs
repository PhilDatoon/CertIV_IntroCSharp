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
    class OneMethod
    {
        static void Main(string[] args)
        {
            string myChoice;
            string[,] address = new string[5, 5] { {"", "", "", "", ""},
                {"", "", "", "", ""}, {"", "", "", "", ""},
                {"", "", "", "", ""} , {"", "", "", "", ""} };
            int ctr = 0;

            OneMethod om = new OneMethod();

            do
            {
                myChoice = om.getChoice(); // call function
                
                // make a decision based on the user's choice
                switch (myChoice)
                {
                    case "A":
                    case "a":
                        om.addNewAddress(address, ctr++); 
                        break;
                    case "D":
                    case "d":
                        om.deleteAddress(address); 
                        break;
                    case "M":
                    case "m":
                        om.modifyAddress(address);
                        break;
                    case "V":
                    case "v":
                        om.viewAddress(address); 
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice.", myChoice);
                        break;
                }

                // pause to allow the user to see the results
                Console.WriteLine();
                Console.Write("Press Enter key to continue...");

                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); // keep going until the user wants to quit
        }

        string getChoice()
        {
            string myChoice;

            // print a menu
            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add new address");
            Console.WriteLine("D - Delete address");
            Console.WriteLine("M - Modify address");
            Console.WriteLine("V - View addresses");
            Console.WriteLine("Q - Quit\n");

            Console.Write("Choice (A, D, M, V, or Q): ");

            // retrieve the user's choice
            myChoice = Console.ReadLine();
            Console.WriteLine();

            return myChoice;
        }

        void addNewAddress(String[,] address, int ctr)
        {   Console.WriteLine("You wish to add an address.");

            address[ctr, 0] = ctr.ToString();
                
            Console.Write("Enter name: ");
            address[ctr, 1] = Console.ReadLine();
            
            Console.Write("Enter suburb: ");
            address[ctr, 2] = Console.ReadLine();
            
            Console.Write("Enter contact number: ");
            address[ctr, 3] = Console.ReadLine();
            
            Console.Write("Enter email address: ");
            address[ctr, 4] = Console.ReadLine();

            ctr++;
        }

        void deleteAddress(String[,] address)
        {
            Console.WriteLine("You wish to delete an address.");
            Console.WriteLine();
            Console.WriteLine("Enter ID of the contact you wish to delete.");

            int id = int.Parse(Console.ReadLine());

            for(int k = 0; k < address.GetLength(0); k++)
                address[id, k] = "";
        }

        void modifyAddress(String[,] address)
        {
            Console.WriteLine("You wish to modify an address.");
            Console.WriteLine();
            Console.WriteLine("Enter ID of the contact you wish to modify.");

            int id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter name: ");
            address[id, 1] = Console.ReadLine();

            Console.Write("Enter suburb: ");
            address[id, 2] = Console.ReadLine();

            Console.Write("Enter contact number: ");
            address[id, 3] = Console.ReadLine();

            Console.Write("Enter email address: ");
            address[id, 4] = Console.ReadLine();
        }

        void viewAddress(String[,] address)
        {
            Console.WriteLine("You wish to view an address.");

            for (int i = 0; i < address.GetLength(0); i++)
            {
                for (int j = 0; j < address.GetLength(1); j++)
                {
                    Console.Write("{0,10}", address[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}