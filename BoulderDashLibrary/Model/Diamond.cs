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
        public Diamond(Square square=) : base(square, "Diamonds", Shapes.D)
        {
        }

        public int PointsWorth
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void Replace(PlayElement e)
        {
            throw new NotImplementedException();
        }
    }
}
