﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDashLibrary.Model.Squares;
using BoulderDashLibrary.Utils;

namespace BoulderDashLibrary.Model
{
    public class NormalWall : Wall
    {
        public NormalWall(Square square) : base(square, "NormalWall", Shapes.W)
        {
        }
    }
}
