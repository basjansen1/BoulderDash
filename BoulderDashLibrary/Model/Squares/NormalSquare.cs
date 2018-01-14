using BoulderDashLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model.Squares
{
    public class NormalSquare : Square, IDestructable
    {
        public NormalSquare()
        {
            _printShape = Shapes.X;
        }

        public void Destroy()
        {
            if (PlayObject != null && PlayObject is IDestructable)
            {
                IDestructable destructable = (IDestructable)PlayObject;
                destructable.Destroy();
            }
            PlayObject = null;
        }
    }
}
