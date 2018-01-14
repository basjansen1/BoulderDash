using BoulderDashLibrary.Model;
using BoulderDashLibrary.Model.Squares;
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
            Console.WriteLine("Legenda");
            Console.WriteLine("R: Rockford(Bestuur hem met de pijltjes toetsen) \nM: Mud(Vakje met modder)\nB: Boulder(Een steen waar Rockford niet doorheen kan graven)");
            Console.WriteLine("D: Diamond(Alle diamanten in het level moeten door Rockford verzameln worden voordat de exit open gaat)");
            Console.WriteLine("W: Wall(Een mur waar Rockford niet doorheen kan graven. Een wall kan wel vernietigd worden door een explosie)");
            Console.WriteLine("S: Steelwall(Een muur waar Rockford niet doorhaan kan graven en sterk genoeg is om explosies te doorstaan");
            Console.WriteLine("F: Firefly(Een zelfstandig bewegende vijand. Als de Firefly de held Rockford aanraakt dan gaat Rockford dood");
            Console.WriteLine("X: Leeg vakje \n");

            Console.WriteLine("Welkom bij het spel Boulder Dash.\nElk level moet binnen een bepaalde tijd worden afgerond!");
            Console.WriteLine("Voor level 1 en 2 is dit binnen 150 seconden");
            Console.WriteLine("Voor elke diamond die je verzamelt scoor je 10 punten, voor elke firefly die vernietigd wordt 250 punten.");
            Console.WriteLine("Druk op een toets om door te gaan...");
            Console.ReadKey();
        }

        public void PrintEndOfGame()
        {
            Console.Clear();
            Console.WriteLine("Je tijd is opgeraakt of je hebt het spel uitgespeeld!");
            Console.WriteLine("Bedankt voor het spelen van Boulder Dash!\nWe zien je graag de volgende keer terug!\n");
            Console.WriteLine("Druk op een toets om het spel af te sluiten.....");

            Console.ReadKey();
            Environment.Exit(0);
        }

        public void PrintField(Square square)
        {
            Console.Clear();

            Square currentColumnSquare = square;
            Square currentRowSquare = currentColumnSquare;

            while (currentColumnSquare != null)
            {
                Console.Write(currentRowSquare.GetPrintShape());
                if (currentRowSquare.RightSquare != null)
                {
                    currentRowSquare = currentRowSquare.RightSquare;
                }
                else
                {
                    currentColumnSquare = currentColumnSquare.DownSquare;
                    currentRowSquare = currentColumnSquare;
                    Console.WriteLine();
                }
            }
        }

        public void ShowLevelFinished(int level, int points)
        {
            Console.Clear();
            Console.WriteLine(string.Format("Je hebt Level {0} uitgespeeld met {1} punten", level, points));
        }

        public void NextLevel(int level)
        {
            Console.WriteLine("Je gaat nu door naar Level " + level);
            Console.WriteLine("Om door te gaan naar level " + level + " moet je een toets indrukken\n\n\n");
        }
    }
}
