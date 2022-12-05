using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Enemy
    {
        public string enemyName;
        public int healthPoints;
        public int locationX;
        public int locationY;

        public Enemy(string EnemyName,   
                    int HealthPoints, 
                    int LocationX, 
                    int LocationY)
        {
            enemyName = EnemyName;
            healthPoints = HealthPoints;
            locationX = LocationX;
            locationY = LocationY;
        }

        public void TakeDamage() 
        {
            healthPoints = healthPoints - 5;
        }

        public (int, int) EnemyLocation()
        {
            return (locationX, locationY);
        }

        public int GetEnemyHealth()
        {
            return healthPoints;
        }

        public int EnemyAttack()
        {
            if(enemyName == "Goblin")
            {
                return 2;
            }
            if (enemyName == "Orc")
            {
                return 3;
            }
            if (enemyName == "Banshee")
            {
                return 5;
            }
            else
            {
                return 0;
            }  
        }

        public string EnemyAttackType()
        {
            if (enemyName == "Goblin")
            {
                return "Body Slam";
            }
            if (enemyName == "Orc")
            {
                return "Cleave";
            }
            if (enemyName == "Banshee")
            {
                return "Screech";
            }
            else
            {
                return "Error";
            }
            
        }


    }
}
