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
        private List<Player> _playerList;

        public Enemy(Square square, string name, Shapes shape, List<Player> playerList) : base(square, name, shape)
        {
            _playerList = playerList;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
