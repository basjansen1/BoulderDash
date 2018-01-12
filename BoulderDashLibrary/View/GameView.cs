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
