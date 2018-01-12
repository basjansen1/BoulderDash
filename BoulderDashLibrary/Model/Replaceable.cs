using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public abstract class Replaceable : PlayElement, IMovable
    {
        public Replaceable(Square square, string name, Shapes shape) : base(square, name, shape)
        {
        }

        public bool CanMove(string direction)
        {
            switch (direction)
            {
                case "Right":
                    if (CurrentSquare.RightSquare.PlayObject == null)
                    {
                        CurrentSquare.CurrentDirection = CurrentPlayObjectDirection.RIGHT;
                        return true;
                    }
                    break;
                case "Left":
                    if (CurrentSquare.LeftSquare.PlayObject == null)
                    {
                        CurrentSquare.CurrentDirection = CurrentPlayObjectDirection.LEFT;
                        return true;
                    }
                    break;
                case "Up":
                    if (CurrentSquare.UpSquare.PlayObject == null)
                    {
                        CurrentSquare.CurrentDirection = CurrentPlayObjectDirection.UP;
                        return true;
                    }
                    break;
                case "Down":
                    if (CurrentSquare.DownSquare.PlayObject == null)
                    {
                        CurrentSquare.CurrentDirection = CurrentPlayObjectDirection.DOWN;
                        return true;
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }

        public bool MoveToAbove()
        {
            if (!CanMove("Up"))
                return false;
            else
            {
                CurrentSquare.UpSquare.AddPlayElement(this);

                CurrentSquare.PlayObject = null;
                return true;
            }
        }

        public bool MoveToBenath()
        {
            if (!CanMove("Down"))
                return false;
            else
            {
                CurrentSquare.DownSquare.AddPlayElement(this);

                CurrentSquare.PlayObject = null;
                return true;
            }
        }

        public bool MoveToLeft()
        {
            if (!CanMove("Left"))
                return false;
            else
            {
                CurrentSquare.LeftSquare.AddPlayElement(this);

                CurrentSquare.PlayObject = null;
                return true;
            }
        }

        public bool MoveToRight()
        {
            if (!CanMove("Right"))
                return false;
            else
            {
                CurrentSquare.RightSquare.AddPlayElement(this);

                CurrentSquare.PlayObject = null;
                return true;
            }
        }

        public abstract void Replace(PlayElement e);
    }
}
