using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public abstract class Player : Creature
    {
        public int Points { get; set; }

        public void AddGatherable(IGatherable g)
        {
            throw new NotImplementedException();
        }
    }
}
