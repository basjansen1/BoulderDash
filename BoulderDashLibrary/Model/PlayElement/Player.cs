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
        public Player(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            Points = 0;
        }

        public int Points { get; set; }

        public void AddGatherable(IGatherable g)
        {
            throw new NotImplementedException();
        }
    }
}
