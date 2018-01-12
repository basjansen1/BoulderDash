using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model.Squares
{
    public abstract class Square
    {
        public Square LeftSquare { get; set; }
        public Square RightSquare { get; set; }
        public Square UpSquare { get; set; }
        public Square DownSquare { get; set; }

        public PlayElement PlayObject { get; set; }
        public char PrintShape { get; set; }

        public virtual bool AddPlayElement(PlayElement e)
        {
            throw new NotImplementedException();
        }

        public virtual bool RemovePlayElement()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}
