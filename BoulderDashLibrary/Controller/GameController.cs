using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Controller
{
    public class GameController
    {
        #region fields
        private FieldController _fieldController;
        private ViewController _viewController;
        private object _testvar;
        #endregion

        #region properties
        public int Level { get; set; }
        #endregion

        #region constructor and methods
        public GameController()
        {
            _fieldController = new FieldController();
            _viewController = new ViewController();
            Level = 3;
        }

        public void StartGame()
        {
            _viewController.ShowStartOfGame();
            PrepareLevel();
            DoGame();
        }

        public void DoGame()
        {
            _viewController.ShowGame(_fieldController.GetField(), _fieldController.GetPlayer());

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        _testvar = _fieldController.GetPlayer().CanMove("Up").ToString(); // remove
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

                _viewController.ShowGame(_fieldController.GetField(), _fieldController.GetPlayer());
            }
            while (keyInfo.Key != ConsoleKey.S);
        }

        public void EndGame()
        {
            Console.Clear();

            _viewController.ShowEndOfGame();
        }

        private void PrepareLevel()
        {
            _fieldController.SetupField(Level);
        }
        #endregion
    }
}
