using BoulderDashLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public class Field
    {
        public List<IGatherable> ToGatherElementsList { get; set; }
        public List<Enemy> EnemieList { get; set; }
        public Player Player { get; set; }
        public ExitWall ExitWall { get; set; }

        public Field(int level)
        {
            foreach(string s in FileReader.ReadFile(level))
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

    }
}
