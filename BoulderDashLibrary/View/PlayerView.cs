using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.View
{
    public class PlayerView
    {
        public void PrintStatistics(int level, int score, int timeLeft)
        {
            Console.WriteLine(string.Format("Je hebt in dit level({0}) een score van {1} en bent {2} seconden bezig", level, score, timeLeft));
        }
    }
}
