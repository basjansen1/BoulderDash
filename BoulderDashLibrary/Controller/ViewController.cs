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
            Console.Clear();
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

        public void ShowLevelFinished(int level)
        {
            Console.Clear();
            Console.WriteLine(string.Format("Je hebt Level {0} uitgespeeld", level));

            Console.WriteLine("Druk op een toets om door te gaan!");
            Console.ReadKey();
        }

        public void GoToNextLevel(int level)
        {
            Console.WriteLine("Je gaat nu door naar Level " + level);
        }
    }
}
