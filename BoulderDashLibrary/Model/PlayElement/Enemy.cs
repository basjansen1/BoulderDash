using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public abstract class Enemy : Creature
    {
        private List<Player> _playerList;

        public Enemy(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            _playerList = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            _playerList.Add(player);
        }

        public abstract void Move();
    }
}
