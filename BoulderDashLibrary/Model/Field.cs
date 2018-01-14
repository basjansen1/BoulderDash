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
        public ExitSquare ExitWall { get; set; }

        public Field(int level)
        {
            _playGroundFactory = new PlayGroundFactory();
            FirstSquare = _playGroundFactory.CreatePlayGround(FileReader.ReadFile(level));
            ToGatherElementsList = new List<IGatherable>();
            EnemieList = new List<Enemy>();
            _playGroundFactory.PlayElements["Gatherables"].ForEach(g => ToGatherElementsList.Add((IGatherable)g));
            _playGroundFactory.PlayElements["Enemies"].ForEach(e => EnemieList.Add((Enemy)e));
            if (_playGroundFactory.PlayElements["Players"] != null)
            {
                Player = (Player)_playGroundFactory.PlayElements["Players"].First();
            }
        }

        // necassary for printing the field
        public Square FirstSquare;

        public void PrintField() // replace this method to the view, used for testing 
        {
            //Square currentColumnSquare = FirstSquare;
            //Square currentRowSquare = currentColumnSquare;

            //while (currentColumnSquare != null)
            //{
            //    Console.Write(currentRowSquare.GetPrintShape());
            //    if (currentRowSquare.RightSquare != null)
            //    {
            //        currentRowSquare = currentRowSquare.RightSquare;
            //    } else
            //    {
            //        currentColumnSquare = currentColumnSquare.DownSquare;
            //        currentRowSquare = currentColumnSquare;
            //        Console.WriteLine();
            //    }
            //}
        }

        public int GetTotalAvailablePoints
        {
            get
            {
                int pointsWorth = 0;

                foreach(var temp in ToGatherElementsList)
                    pointsWorth += temp.PointsWorth;

                return pointsWorth;
            }
        }
    }
}
