using BoulderDashLibrary.Model.Squares;
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
            int currentRow = 0;
            int currentColum = 0;
            Square currentSquare = null;
            string[]rows = FileReader.ReadFile(level);

            

            foreach(string s in rows)
            {
                Console.WriteLine(s);
            }
        }

        // necassary for printing the field
        private Square _firstSquare;

        public void PrintField()
        {
            Square currentColumnSquare = _firstSquare;
            Square currentRowSquare = currentColumnSquare;

            while (currentColumnSquare != null)
            {
                //  currentRowSquare.Print();
                if (currentRowSquare.RightSquare != null)
                {
                    currentRowSquare = currentRowSquare.RightSquare;
                } else
                {
                    currentColumnSquare = currentColumnSquare.DownSquare;
                    currentRowSquare = currentColumnSquare;
                }
            }
        }
    }
}
