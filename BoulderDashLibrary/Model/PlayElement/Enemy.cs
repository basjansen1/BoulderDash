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

        public Enemy(Square square, string name, Shapes shape) : base(square, name, shape)
        {
            _playerList = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            _playerList.Add(player);
            Console.WriteLine("Added player");
        }

        public void Move()
        {
            if (CurrentSquare.LeftSquare.PlayObject is Player
                || CurrentSquare.RightSquare.PlayObject is Player
                || CurrentSquare.UpSquare.PlayObject is Player
                || CurrentSquare.DownSquare.PlayObject is Player)
            {
                // dead. Blast radius is 3*3. Remove 3 items from the field.
            }
            else
            {
                if (CurrentSquare.PlayObject is FireFly)
                {
                    
                }
            }
        }
    }
}
