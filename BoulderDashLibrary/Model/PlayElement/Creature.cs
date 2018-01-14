using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public abstract class Creature : Replaceable, IExplodable
    {
        public bool Alive { get; set; }

        public Creature(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            Alive = true;
        }

        public override void Destroy()
        {
            Die();
            base.Destroy();
        }

        public void Die()
        {
            this.Alive = false;
        }

        public void Explode()
        {
            List<Square> squareList = new List<Square>();
            if (CurrentSquare.UpSquare != null)
            {
                squareList.Add(CurrentSquare.UpSquare);
            }
            if (CurrentSquare.DownSquare != null)
            {
                squareList.Add(CurrentSquare.DownSquare);
            }
            if (CurrentSquare.LeftSquare != null)
            {
                squareList.Add(CurrentSquare.LeftSquare);
                if (CurrentSquare.LeftSquare.UpSquare != null)
                {
                    squareList.Add(CurrentSquare.LeftSquare.UpSquare);
                }
                if (CurrentSquare.LeftSquare.DownSquare != null)
                {
                    squareList.Add(CurrentSquare.LeftSquare.DownSquare);
                }
            }
            if (CurrentSquare.RightSquare != null)
            {
                squareList.Add(CurrentSquare.RightSquare);
                if (CurrentSquare.RightSquare.UpSquare != null)
                {
                    squareList.Add(CurrentSquare.RightSquare.UpSquare);
                }
                if (CurrentSquare.RightSquare.DownSquare != null)
                {
                    squareList.Add(CurrentSquare.RightSquare.DownSquare);
                }
            }

            foreach(Square square in squareList)
            {
                if (square is IDestructable)
                {
                    IDestructable destructableSquare = (IDestructable)square;
                    destructableSquare.Destroy();
                }
            }
        }
    }
}
