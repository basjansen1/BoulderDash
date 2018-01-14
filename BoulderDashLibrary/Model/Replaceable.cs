using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public abstract class Replaceable : PlayElement, IMovable, IDestructable
    {
        public Replaceable(Square square, string name, Shapes shape) : base(square, name, shape)
        {
        }

        public virtual bool CanMove(string direction)
        {
            Square requestedSquare = null;

            switch (direction)
            {
                case "Right":
                    requestedSquare = CurrentSquare.RightSquare;
                    break;
                case "Left":
                    requestedSquare = CurrentSquare.LeftSquare;
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
            if (requestedSquare.PlayObject == null || !(requestedSquare.PlayObject is Material))
            {
                return true;
            }
            return false;
        }

        public virtual void Destroy()
        {
            CurrentSquare.RemovePlayElement();
           // CurrentSquare = null;
        }

        public virtual bool MoveToAbove()
        {
            if (!CanMove("Up"))
                return false;
            else
            {
                CurrentSquare.UpSquare.AddPlayElement(this);
                CurrentSquare.RemovePlayElement();
                CurrentSquare = CurrentSquare.UpSquare;

                return true;
            }
        }

        public virtual bool MoveToBenath()
        {
            if (!CanMove("Down"))
                return false;
            else
            {
                CurrentSquare.DownSquare.AddPlayElement(this);
                CurrentSquare.RemovePlayElement();
                CurrentSquare = CurrentSquare.DownSquare;
                return true;
            }
        }

        public virtual bool MoveToLeft()
        {
            if (!CanMove("Left"))
                return false;
            else
            {
                CurrentSquare.LeftSquare.AddPlayElement(this);
                CurrentSquare.RemovePlayElement();
                CurrentSquare = CurrentSquare.LeftSquare;
                return true;
            }
        }

        public virtual bool MoveToRight()
        {
            if (!CanMove("Right"))
                return false;
            else
            {
                CurrentSquare.RightSquare.AddPlayElement(this);
                CurrentSquare.RemovePlayElement();
                CurrentSquare = CurrentSquare.RightSquare;
                return true;
            }
        }
    }
}
