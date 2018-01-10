using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public abstract class Square
    {
        public object LeftSquare { get; set; }
        public object RightSquare { get; set; }
        public object UpSquare { get; set; }
        public object DownSquare { get; set; }

        public PlayElement PlayObject { get; set; }
        public char PrintShape { get; set; }

        public bool AddPlayElement(PlayElement e)
        {
            throw new NotImplementedException();
        }

        public bool RemovePlayElement()
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable()
        {
            throw new NotImplementedException();
        }
    }
}
