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
            Console.WriteLine("Welkom bij het spel Boulder Dash.\nElk level moet binnen een bepaalde tijd worden afgerond!");
            Console.WriteLine("Voor level 1 en 2 is dit binnen 150 seconden");
            Console.WriteLine("Voor elke diamond die je verzamelt scoor je 10 punten, voor elke firefly die vernietigd wordt 250 punten.");
            Console.WriteLine("Klik op enter om door te gaan...");
            Console.ReadKey();
        }

        public void PrintEndOfGame()
        {
            Console.WriteLine();
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
    }
}
