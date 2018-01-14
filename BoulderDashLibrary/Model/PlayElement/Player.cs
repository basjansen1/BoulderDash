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
        public List<IGatherable> ToGatherItemsList { get; set; }
        public int Points { get; set; }

        public Player(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            Points = 0;
            ToGatherItemsList = new List<IGatherable>();
        }

        public void CollectGatherable(IGatherable g)
        {
            if (ToGatherItemsList.Contains(g))
            {
                Points += g.PointsWorth;
                ToGatherItemsList.Remove(g);
            }
        }

        public void AddToCollectGatherable(IGatherable g)
        {
            ToGatherItemsList.Add(g);
        }

        public bool GatheredAllItems()
        {
            return ToGatherItemsList.Count() == 0;
        }

        public bool SatisFiedTask()
        {
            return GatheredAllItems() && CurrentSquare is ExitSquare;
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
                        Boulder boulder = (Boulder)requestedSquare.PlayObject;
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
                CollectGatherable((IGatherable)requestedSquare.PlayObject);
                return true;
            }
            else if (requestedSquare.PlayObject is Creature || requestedSquare.PlayObject is Wall || requestedSquare.PlayObject is Boulder)
            {
                return false;
            } else if (requestedSquare is ExitSquare)
            {
                return GatheredAllItems();
            }

            return true;
        }
    }
}
