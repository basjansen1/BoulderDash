using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public abstract class Player : Creature
    {
        public Player(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            Points = 0;
        }

        public int Points { get; set; }

        public void AddGatherable(IGatherable g)
        {
            Points += g.PointsWorth;
        }

        public override bool CanMove(string direction)
        {
            Square requestedSquare = null;

            switch (direction)
            {
                case "Right":
                    requestedSquare = CurrentSquare.RightSquare;

                    if (requestedSquare.PlayObject is Boulder)
                    {
                        Boulder boulder = (Boulder) requestedSquare.PlayObject;
                        return boulder.MoveToRight();
                    }
                    break;
                case "Left":
                    requestedSquare = CurrentSquare.LeftSquare;

                    if (requestedSquare.PlayObject is Boulder)
                    {
                        Boulder boulder = (Boulder)requestedSquare.PlayObject;
                        return boulder.MoveToLeft();
                    }
                    break;
                case "Up":
                    requestedSquare = CurrentSquare.UpSquare;
                    break;
                case "Down":
                    requestedSquare = CurrentSquare.DownSquare;
                    break;
                default:
                    return false;
            }

            if (requestedSquare.PlayObject is IGatherable)
            {
                AddGatherable((IGatherable) requestedSquare.PlayObject);
                return true;
            } else if (requestedSquare.PlayObject is Creature || requestedSquare.PlayObject is Wall)
            {
                return false;
            }

            return true;
        }
    }
}
