using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public abstract class Creature : Replaceable
    {
        public bool Alive { get; set; }

        public Creature(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            Alive = true;
        }

        public void Die()
        {
            this.Alive = false;
        }
    }
}
