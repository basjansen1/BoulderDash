using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model.Squares
{
    public class AssetSquare : Square, IDestructable
    {
        public bool ContainsAsset { get; set; }

        public AssetSquare()
        {
            ContainsAsset = true;
        }
        public override bool AddPlayElement(PlayElement e)
        {
            if (e is Player)
            {
                ContainsAsset = false;
            }
            return base.AddPlayElement(e);
        }

        public override Shapes GetPrintShape()
        {
            if (ContainsAsset)
            {
                return PlayObject == null ? _printShape : PlayObject.Shape;
            } else
            {
                return PlayObject == null ? Shapes.X : PlayObject.Shape;
            }
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
