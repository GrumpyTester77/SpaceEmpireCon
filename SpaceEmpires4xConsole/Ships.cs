using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEmpires4xConsole
{
    class Ships
    {
        public int move;
        public int tatics;
        public char experience;
        public int attackTech;
        public int defenceTech;

        public Ships()
        {
            move = 1;
            tatics = 0;
            experience = 'S';
            attackTech = 0;
            defenceTech = 0;
        }

        public Ships(int movement, int tat, char exp, int attTech, int defTech)
        {
            move = movement;
            tatics = tat;
            experience = exp;
            attackTech = attTech;
            defenceTech = defTech;
        }

        public void GetShipStats()
        {
            Console.WriteLine("Move: " + move);
            Console.WriteLine("Tatics: " + tatics);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("Attack Tech: " + attackTech);
            Console.WriteLine("Defence Tech: " + defenceTech);
        }

        public void UpdateBasicShipStats(int movement, int tat, char exp, int attTech, int defTech)
        {
            move = movement;
            tatics = tat;
            experience = exp;
            attackTech = attTech;
            defenceTech = defTech;
        }
    }

}
