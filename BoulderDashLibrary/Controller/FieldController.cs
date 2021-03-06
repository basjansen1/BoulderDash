﻿using BoulderDashLibrary.Model;
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

        public List<Enemy> GetEnemies()
        {
           return _field.EnemieList;
        }

        public Square GetField()
        {
            return _field.FirstSquare;
        }

        public bool LevelCompleted()
        {
            return GetPlayer().SatisFiedTask();
        }

        public Player GetPlayer()
        {
            return _field.Player;
        }
        #endregion
    }
}
