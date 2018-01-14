using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class FireFly : Enemy
    {
        public FireFly(Square square) : base(square, "Firefly", Shapes.F)
        {
        }

        public override bool CanMove(string direction)
        {
            Square requestedSquare = null;

            switch (direction)
            {
                case "Left":
                    requestedSquare = CurrentSquare.LeftSquare;

                    if (requestedSquare.PlayObject == null)
                        return true;
                    else
                        return CanMove("Up");
                case "Up":
                    requestedSquare = CurrentSquare.UpSquare;

                    if (requestedSquare.PlayObject == null)
                        return true;                  
                    break;
            }

            return false;
        }

        public override void Move()
        {
            //if (CurrentSquare.LeftSquare.PlayObject is Player
            //        || CurrentSquare.RightSquare.PlayObject is Player
            //        || CurrentSquare.UpSquare.PlayObject is Player
            //        || CurrentSquare.DownSquare.PlayObject is Player)
            //{
            //    // dead. Blast radius is 3*3. Remove 3 items from the field.
            //}
            //else
            //{

            //}


        }
    }
}
