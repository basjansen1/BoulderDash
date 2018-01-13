using BoulderDashLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.View
{
    public class GameView
    {
        public void PrintStartOfGame()
        {
            Console.WriteLine("Welkom bij het spel Boulder Dash. \n Elk level moet binnen een bepaalde tijd worden afgerond!");
            Console.WriteLine("Voor elvel 1 en 2 is dit binnen 150 seconden");
            Console.WriteLine("Voor elke diamond die je verzamelet scoor je 10 punten, voor elke firefly die vernietigd wordt 250 punten.");

            Console.WriteLine("\n R: Rockford(Bestuur hem met de pijltjes toetsen) \n M: Mud(Vakje met modder)\n B: Boulder(Een steen waar Rockford niet doorheen kan graven)");
            Console.WriteLine("D: Diamond(Alle diamanten in het level moeten door Rockford verzameln worden voordat de exit open gaat)");
            Console.WriteLine("W: Wall(Een mur waar Rockford niet doorheen kan graven. Een wall kan wel vernietigd worden door een explosie)");
            Console.WriteLine("S: Steelwall(Een muur waar Rockford niet doorhaan kan graven en sterk genoeg is om explosies te doorstaan");
            Console.WriteLine("F: Firefly(Een zelfstandig bewegende vijand. Als de Firefly de held Rockford aanraakt dan gaat Rockford dood");
        }

        public void PrintEndOfGame()
        {
            Console.WriteLine();
        }

        public void PrintField(Field field)
        {
            Console.WriteLine();
        }
    }
}
