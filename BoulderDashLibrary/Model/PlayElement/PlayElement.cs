using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public abstract class PlayElement
    {
        public Square CurrentSquare { get; set; }
        public string Name { get; set; }
        public Shapes Shape { get; set; }

        public PlayElement(Square square, string name, Shapes shape)
        {
            CurrentSquare = square;
            Name = name;
            Shape = shape;
        }
    }
}
