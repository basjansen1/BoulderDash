using BoulderDashLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model.Squares
{
    public abstract class Square
    {
        #region properties
        public Square LeftSquare { get; set; }
        public Square RightSquare { get; set; }
        public Square UpSquare { get; set; }
        public Square DownSquare { get; set; }

        public PlayElement PlayObject { get; set; }
        protected Shapes _printShape;
        #endregion

        #region methods
        public virtual bool AddPlayElement(PlayElement e)
        {
            PlayObject = e;
            return true;
        }

        public virtual bool RemovePlayElement()
        {
            PlayObject = null;
            return true;
        }

        public virtual Shapes GetPrintShape()
        {
            if (PlayObject == null)
            {
                return _printShape;
            }
            else
            {
                return PlayObject.Shape;
            }
        }
        #endregion
    }
}
