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
            Square newSquare = null;

            switch (direction)
            {
                case "Right":
                    newSquare = CurrentSquare.RightSquare;

                    if (newSquare.PlayObject is FireFly)
                    {
                        base.Die();

                        return false;
                    }

                    if (CurrentSquare.RightSquare == null)
                        return true;
                    break;
                case "Left":
                    newSquare = CurrentSquare.LeftSquare;

                    if (newSquare.PlayObject is FireFly)
                    {
                        base.Die();

                        return false;
                    }

                    if (CurrentSquare.LeftSquare == null)
                        return true;
                    break;
                case "Up":
                    newSquare = CurrentSquare.UpSquare;
                    if (newSquare.PlayObject is FireFly)
                    {
                        base.Die();

                        return false;
                    }

                    if (newSquare == null || !(newSquare.PlayObject is Boulder) || !(newSquare.PlayObject is Wall))
                        return true;
                    break;
                case "Down":
                    newSquare = CurrentSquare.DownSquare;
                    if (newSquare.PlayObject is FireFly)
                    {
                        base.Die();

                        return false;
                    }

                    if (newSquare.PlayObject == null || !(newSquare.PlayObject is Boulder) 
                        || !(newSquare.PlayObject is Wall))
                        return true;
                    break;
                default:
                    return false;
            }

            return false;
        }
    }
}
