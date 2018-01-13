using BoulderDashLibrary.Model;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Controller
{
    public class FieldController
    {
        #region fields
        private Field _field;
        #endregion

        #region constructor and methods
        public FieldController()
        {

        }

        public void SetupField(int level)
        {
            _field = new Field(level);
        }

        public void UpdateField()
        {

        }

        public bool CheckGameOver()
        {
            return true;
        }

        public Square GetField()
        {
            return _field.FirstSquare;
        }

        public Player GetPlayer()
        {
            return _field.Player;
        }
        #endregion
    }
}
