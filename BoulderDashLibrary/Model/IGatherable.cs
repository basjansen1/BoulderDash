﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDashLibrary.Model
{
    public interface IGatherable
    {
        int PointsWorth { get;}
        List<Player> PlayerList { get; set; }

        void AddPlayers(Player player);
    }
}
