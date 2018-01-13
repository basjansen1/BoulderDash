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
        private PlayGroundFactory _playGroundFactory;
        public List<IGatherable> ToGatherElementsList { get; set; }
        public List<Enemy> EnemieList { get; set; }
        public Player Player { get; set; }
        public ExitWall ExitWall { get; set; }

        public Field(int level)
        {
            _playGroundFactory = new PlayGroundFactory();
            _firstSquare = _playGroundFactory.CreatePlayGround(FileReader.ReadFile(level));
            ToGatherElementsList = new List<IGatherable>();
            EnemieList = new List<Enemy>();
            _playGroundFactory.PlayElements["Gatherables"].ForEach(g => ToGatherElementsList.Add((IGatherable)g));
            _playGroundFactory.PlayElements["Enemies"].ForEach(e => EnemieList.Add((Enemy)e));
            Player = (Player) _playGroundFactory.PlayElements["Players"].First();
            ExitWall = (ExitWall) _playGroundFactory.PlayElements["Exits"].First();
        }

        // necassary for printing the field
        private Square _firstSquare;

        public void PrintField() // replace this method to the view, used for testing 
        {
            Square currentColumnSquare = _firstSquare;
            Square currentRowSquare = currentColumnSquare;

            while (currentColumnSquare != null)
            {
                Console.Write(currentRowSquare.GetPrintShape());
                if (currentRowSquare.RightSquare != null)
                {
                    currentRowSquare = currentRowSquare.RightSquare;
                } else
                {
                    currentColumnSquare = currentColumnSquare.DownSquare;
                    currentRowSquare = currentColumnSquare;
                    Console.WriteLine();
                }
            }
        }
    }
}
