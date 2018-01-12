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
        private Square _square;
        private string _name;
        private Shapes _shape;

        public Replaceable(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            _square = square;
            _name = name;
            _shape = shape;
        }

        public bool CanMove(string direction)
        {
            switch (direction)
            {
                case "Right":
                    if (_square.RightSquare.PlayObject == null)
                        return true;
                    break;
                case "Left":
                    if (_square.LeftSquare.PlayObject == null)
                        return true;
                    break;
                case "Up":
                    if (_square.UpSquare.PlayObject == null)
                        return true;
                    break;
                case "Down":
                    if (_square.DownSquare.PlayObject == null)
                        return true;
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
                CurrentSquare.UpSquare.AddPlayElement(this);

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
                CurrentSquare.UpSquare.AddPlayElement(this);

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
                CurrentSquare.UpSquare.AddPlayElement(this);

                CurrentSquare.PlayObject = null;
                return true;
            }
        }

        public abstract void Replace(PlayElement e);
    }
}
