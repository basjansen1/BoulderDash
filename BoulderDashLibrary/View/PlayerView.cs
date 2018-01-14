using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.View
{
    public class PlayerView
    {
        public void PrintStatistics(int score, int timeLeft)
        {
            Console.WriteLine(string.Format("Je hebt in dit level een score van {0} en bent {1} seconden bezig", score, timeLeft));
        }
    }
}
