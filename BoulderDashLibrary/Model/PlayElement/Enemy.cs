using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class Enemy : Creature
    {
        public Enemy(Square square, string name, Shapes shape) : base(square, name, shape)
        {
        }

        public void Move()
        {
            if (CurrentSquare.LeftSquare.PlayObject is Player
                || CurrentSquare.RightSquare.PlayObject is Player
                || CurrentSquare.UpSquare.PlayObject is Player
                || CurrentSquare.DownSquare.PlayObject is Player)
            {
                // dead. Blast radius is 3*3. Remove 3 items from the field.
            }
            else
            {
                if (CurrentSquare.PlayObject is FireFly)
                {
                    switch(CurrentSquare.CurrentDirection)
                    {
                        // TODO-> Move object
                        case CurrentPlayObjectDirection.UP:
                            break;
                        case CurrentPlayObjectDirection.DOWN:
                            break;
                        case CurrentPlayObjectDirection.LEFT:
                            break;
                        case CurrentPlayObjectDirection.RIGHT:
                            break;
                    }
                }
            }
        }

        public override void Replace(PlayElement e)
        {
            CurrentSquare.PlayObject = e;
        }
    }
}
