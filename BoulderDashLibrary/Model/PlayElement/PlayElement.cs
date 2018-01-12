using BoulderDashLibrary.Model.Squares;
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
       // public Shape Shape { get; set; }
    }
}
