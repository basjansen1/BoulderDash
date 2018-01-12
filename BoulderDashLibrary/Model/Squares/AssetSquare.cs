﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model.Squares
{
    public class AssetSquare : Square
    {
        public bool ContainsAsset { get; set; }

        public override bool AddPlayElement(PlayElement e)
        {
            throw new NotImplementedException();
        }
    }
}
