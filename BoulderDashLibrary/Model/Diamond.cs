using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class Diamond : Slipperable, IGatherable
    {
        public Diamond(Square square) : base(square, "Diamonds", Shapes.D)
        {
        }

        public int PointsWorth
        {
            get
            {
                return 10;
            }
        }

        public bool Gathered { get; set; }

        public override bool CanMove(string direction)
        {
            throw new NotImplementedException();
        }
    }
}
