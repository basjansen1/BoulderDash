using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class Boulder : Slipperable
    {
        public Boulder(Square square) : base(square, "Boulder", Shapes.B)
        {
        }
    }
}
