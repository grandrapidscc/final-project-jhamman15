using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Powerup
    {
        public string powerupName;
        public int locationX;
        public int locationY;

        public Powerup(string PowerupName, int LocationX, int LocationY)
        {
            powerupName = PowerupName;
            locationX = LocationX;
            locationY = LocationY;
            
        }

        public int PointsRestored()
        {
            if (powerupName == "Health Potion")
            {
                return 10;
            }
            if (powerupName == "Magicka Potion")
            {
                return 20;
            }
            return 0;
        }
    }
}
