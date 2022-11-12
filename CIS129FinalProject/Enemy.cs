﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Enemy
    {
        private int _healthPoints;
        private int _locationX;
        private int _locationY;

        public Enemy(int healthPoints, int locationX, int locationY)
        {
            _healthPoints = healthPoints;
            _locationX = locationX;
            _locationY = locationY;
        }

        public void TakeDamage() 
        {
            _healthPoints = _healthPoints - 5;
        }

        public (int, int) EnemyLocation()
        {
            return (_locationX, _locationY);
        }

        public int GetGoblinHealth()
        {
            return _healthPoints;
        }

    }
}
