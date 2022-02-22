using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEmpires4xConsole
{
    class MainMenu
    {
        public static void Main_Menu()
        { 
            
            Console.WriteLine("Main Menu \n");
            Console.WriteLine("Option 1, Create New Ship");
            Console.WriteLine("Option 2, Update Ship");
            Console.WriteLine("Option 3, View Ships");
            Console.WriteLine("Option 4, Exit");
            Console.WriteLine("Please select an options from the list.");
            string inputKey = Console.ReadLine();
            int result = Int32.Parse(inputKey);

            if (result == 1)
            {

                Console.Clear();
                ShipMenu.Ship_Menu();
                Console.Clear();

            }

            else if (result == 2)
            {
                Console.Clear();

                Console.Clear();

            }

            else if (result == 3)
            {
                Console.Clear();
                
                

                Console.Clear();

            }

            else if (result == 4)
            {
                Environment.Exit(0);

            }

            else
            {
                Console.Clear();
                Console.WriteLine("invalid option");
                Console.Clear();

            }
        }
    }
}
