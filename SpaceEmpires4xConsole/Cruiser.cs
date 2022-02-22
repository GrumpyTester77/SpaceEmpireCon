using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEmpires4xConsole
{
    class Cruiser : Ships
    {
        public int attackStrength = 3;
        public int defenceStrenght = 1;
        public int exploration = 0;
        public string name;

        public void GetCruiserStats()
        {
            Console.WriteLine("Attack Strength: " + attackStrength);
            Console.WriteLine("Defence Strength: " + defenceStrenght);
            Console.WriteLine("Point Defence: " + exploration);
        }

        public void UpdateCruiserStats(int attStr, int defStr, int exp)
        {
            attackStrength = attStr;
            defenceStrenght = defStr;
            exploration = exp;

        }
    }
}
