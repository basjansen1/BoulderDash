using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public interface IMovable
    {
        bool MoveToLeft();
        bool MoveToRight();
        bool MoveToAbove();
        bool MoveToBenath();
        bool CanMove(string direction);
    }
}
