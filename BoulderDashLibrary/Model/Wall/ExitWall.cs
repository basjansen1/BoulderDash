using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class ExitWall : SteelWall
    {
        public ExitWall(Square square) : base(square)
        {
            Shape = Shapes.E;
            Name = "ExitWall";
        }
    }
}
