using BoulderDashLibrary.Model;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Controller
{
    public class ViewController
    {
        private GameView _gameView;
        private PlayerView _playerView;

        public ViewController()
        {
            _gameView = new GameView();
            _playerView = new PlayerView();
        }

        public void ShowStartOfGame()
        {
            _gameView.PrintStartOfGame();
        }

        public void ShowGame(Square field, Player player)
        {
            _playerView.PrintScore();
            _gameView.PrintField(field);
        }

        public void ShowEndOfGame()
        {
            _gameView.PrintEndOfGame();
        }

        public void ShowField(Square field)
        {
            _gameView.PrintField(field);
        }

        public void ShowPlayerStatistics(Player player)
        {
            _playerView.PrintScore();
        }
    }
}
