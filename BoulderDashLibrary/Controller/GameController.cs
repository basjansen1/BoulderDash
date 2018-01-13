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
        #endregion

        #region properties
        public int Level { get; set; }
        #endregion

        #region constructor and methods
        public GameController()
        {
            _fieldController = new FieldController();
            _viewController = new ViewController();
            Level = 1;
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
                        Console.WriteLine("up");
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("down");
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("left");
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("right");
                        _fieldController.UpdateField();
                        break;
                    case ConsoleKey.R:
                        break;
                }
            }
            while (keyInfo.Key != ConsoleKey.S || keyInfo.Key != ConsoleKey.R);
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
