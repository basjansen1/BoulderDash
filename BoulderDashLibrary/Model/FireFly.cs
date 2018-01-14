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
                    break;
                case "Up":
                    requestedSquare = CurrentSquare.UpSquare;                
                    break;
            }

            if (requestedSquare.PlayObject is Wall)
                return false;
            else if (requestedSquare.PlayObject == null)
                return true;

            return false;
        }

        public override void Move()
        {
            if (!MoveToLeft())
                MoveToAbove();
        }
    }
}
