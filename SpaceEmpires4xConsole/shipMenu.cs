using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEmpires4xConsole
{
    class ShipMenu
    {

        public static void Ship_Menu()
        { 
            Console.WriteLine("Ship Menu \n");
            Console.WriteLine("Option 1, Create Scout");
            Console.WriteLine("Option 2, Create Destroyer");
            Console.WriteLine("Option 3, Create Cruiser");
            Console.WriteLine("Option 4, Exit");
            Console.WriteLine("Please select an options from the list.");
            string inputKey = Console.ReadLine();
            int result = Int32.Parse(inputKey);

            if (result == 1)
            {

                Console.Clear();
                Console.WriteLine("Please enter name of ship");
                string input = Console.ReadLine();
                Scout.CreateScout(input);
                MainMenu.Main_Menu();
                Console.Clear();

            }

            else if (result == 2)
            {
                Console.Clear();

                Console.Clear();

            }

            else if (result == 2)
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
