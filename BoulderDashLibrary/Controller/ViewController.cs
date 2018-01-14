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
            _playerView.PrintScore(player.Points);
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

        public void ShowLevelFinished(int level, int points)
        {
            _gameView.ShowLevelFinished(level, points);
        }

        public void GoToNextLevel(int level)
        {
            _gameView.NextLevel(level);
        }
    }
}
