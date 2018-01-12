using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class Enemy : Creature
    {
        private Player _player;

        public Enemy(Square square, string name, Shapes shape) : base(square, name, shape)
        {
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
