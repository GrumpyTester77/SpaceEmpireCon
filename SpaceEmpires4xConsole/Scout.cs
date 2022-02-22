using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEmpires4xConsole
{
    class Scout : Ships
    {
        public int attackStrength = 3;
        public int defenceStrenght = 0;
        public int pointDefence = 0;
        public string name;

        public void GetScoutStats()
        {

            GetShipStats();
            Console.WriteLine("Attack Strength: " + attackStrength);
            Console.WriteLine("Defence Strength: " + defenceStrenght);
            Console.WriteLine("Point Defence: " + pointDefence);
        }

        public void UpdateScoutStats(int attStr, int defStr, int ptDef)
        {
            attackStrength = attStr;
            defenceStrenght = defStr;
            pointDefence = ptDef;

        }

        public static void CreateScout(string input)
        {

            Scout scout = new Scout();
            scout.name = input;
            

        }

        public static void ViewScouts()
        {
            
        }

        public static void SaveScoutList()
        { 
            
        }
    }
}
