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
        }

        public void EndGame()
        {

        }

        private void PrepareLevel()
        {
            _fieldController.SetupField(Level);
        }
        #endregion
    }
}
