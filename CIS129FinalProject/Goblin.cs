using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Goblin : Enemy
    {
        public Goblin(
            int healthPoints, 
            int locationX, 
            int locationY,
            int enemyId) 
            : base(healthPoints, locationX, locationY, enemyId)
        {

        }
    }
}
