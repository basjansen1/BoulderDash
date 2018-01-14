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
                case "Right":
                    requestedSquare = CurrentSquare.RightSquare;
                    break;
                case "Up":
                    requestedSquare = CurrentSquare.UpSquare;                
                    break;
                case "Down":
                    requestedSquare = CurrentSquare.DownSquare;
                    break;
            }

            if (requestedSquare.PlayObject is Creature)
            {
                Creature creature = (Creature)requestedSquare.PlayObject;
                creature.Explode();
                creature.Destroy();
                Explode();
                Destroy();
                return true;
            } else if (requestedSquare is AssetSquare)
            {
                AssetSquare assetSquare = (AssetSquare)requestedSquare;
                return !assetSquare.ContainsAsset;
            } else if (requestedSquare is NormalSquare && requestedSquare.PlayObject == null)
            {
                return true;
            }

            return false;
        }

        public override void Move()
        {
            if (!MoveToLeft())
            {
                if (!MoveToAbove())
                {
                    if (!MoveToRight())
                    {
                        MoveToBenath();
                    }
                }
            }
        }
    }
}
