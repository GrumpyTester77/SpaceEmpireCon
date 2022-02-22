using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEmpires4xConsole
{
    class Destroyer : Ships
    {
        public int attackStrength = 3;
        public int defenceStrenght = 1;
        public int scanner = 0;
        public string name;

        public void GetDestroyerStats()
        {
            Console.WriteLine("Attack Strength: " + attackStrength);
            Console.WriteLine("Defence Strength: " + defenceStrenght);
            Console.WriteLine("Point Defence: " + scanner);
        }

        public void UpdateDestroyerStats(int attStr, int defStr, int scan)
        {
            attackStrength = attStr;
            defenceStrenght = defStr;
            scanner = scan;

        }
    }
}
