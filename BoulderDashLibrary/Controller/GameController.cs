using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Controller
{
    public class GameController
    {
        #region fields
        private FieldController _fieldController;
        private ViewController _viewController;
        private int _elapsedTime;
        #endregion

        #region properties
        public int Level { get; set; }
        #endregion

        #region constructor and methods
        public GameController()
        {
            _fieldController = new FieldController();
            _viewController = new ViewController();
            Level = 2;
        }

        public void StartGame()
        {
            _viewController.ShowStartOfGame();
            PrepareLevel();
            StartTimer();
            DoGame();
        }

        private void StartTimer()
        {
            var timer = new System.Threading.Timer(TimerCallBack, null, 0, 1000);
        }

        private void TimerCallBack(object o)
        {
            _elapsedTime++;
        }

        private bool TimeIsUp()
        {
            if (Level == 1 || Level == 2)
                return _elapsedTime >= 150;
            else
                return false;
        }

        public void DoGame()
        {
            _viewController.ShowGame(_fieldController.GetField(), _fieldController.GetPlayer(), _elapsedTime);

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();
                
                if (_fieldController.GetEnemies().Any())
                {
                    Task mytask = Task.Run(() =>
                    {
                        Thread.Sleep(200);

                        // Move the enemy 5 times.
                        for (int i = 0; i < 5; i++)
                            _fieldController.GetEnemies().ForEach(e => e.Move());
                    });
                }

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        _fieldController.GetPlayer().MoveToAbove();
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.DownArrow:
                        _fieldController.GetPlayer().MoveToBenath();
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.LeftArrow:
                        _fieldController.GetPlayer().MoveToLeft();
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.RightArrow:
                        _fieldController.GetPlayer().MoveToRight();
                        _fieldController.UpdateField();
                        break;
                }

                _viewController.ShowGame(_fieldController.GetField(), _fieldController.GetPlayer(), _elapsedTime);
            }
            while (!_fieldController.LevelCompleted() || !TimeIsUp());

            if (TimeIsUp())
            {
                EndGame();
                return;
            }

            LevelFinished();

            if (Level < 3)
                GoToNextLevel();
            else
                EndGame();
        }

        private void GoToNextLevel()
        {
            Level++;
            _viewController.GoToNextLevel(Level);

            PrepareLevel();
        }

        private void LevelFinished()
        {
            _viewController.ShowLevelFinished(Level, _fieldController.GetPlayer().Points);
        }

        public void EndGame()
        {
            _viewController.ShowEndOfGame();
        }

        private void PrepareLevel()
        {
            _fieldController.SetupField(Level);
        }
        #endregion
    }
}
