using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CIS129FinalProject
{
    public class Wizert
    {
        //define wizert and create constructor
        public int healthPoints;
        public int magickaPoints;

        public Wizert(int HealthPoints, int MagickaPoints)
        {
            healthPoints = HealthPoints;
            magickaPoints = MagickaPoints;
        }

        //action methods
        public void UseFireBall()
        {
            if( magickaPoints > 0)
            {
                magickaPoints = magickaPoints - 3;
            }
            else
            {
                Console.WriteLine("Not enough Magicka Points!");
            }
            
        }

        //method to return magicka points
        public int GetMagickaPoints()
        {
            return magickaPoints;
        }

        //method to take damage depending on attack
        public void TakeDamage(int attackValue)
        {
            healthPoints = healthPoints - attackValue;
        }

        //method to get current health
        public int GetCurrentHealth()
        {
            return healthPoints;
        }

        //method to heal and take away magicka
        public void Heal()
        {
            if(magickaPoints > 5)
            {
                healthPoints = healthPoints + 3;
                magickaPoints = magickaPoints - 5;
            }
            else
            {
                Console.WriteLine("Not enough Magicka Points");
            }
            
        }

        //keep wizert location stored
        public int wizertLocationX;
        public int wizertLocationY;

        //move function for each direction
        public void MoveNorth()
        {
            if(wizertLocationY >= 0 && wizertLocationY < 5)
            {
                wizertLocationY += 1;
            }
            else
            {
                Console.WriteLine("There is no door that direction.");
            }

        }

        public void MoveSouth()
        {
            if(wizertLocationY > 0 && wizertLocationY <= 5)
            {
                wizertLocationY -= 1;
            }
            else
            {
                Console.WriteLine("There is no door that direction.");
            }
            
        }

        public void MoveEast()
        {
            if (wizertLocationX >= 0 && wizertLocationX < 5)
            {
                wizertLocationX += 1;
            }
            else
            {
                Console.WriteLine("There is no door that direction.");
            }
        }

        public void MoveWest()
        {
            if (wizertLocationX > 0 && wizertLocationX <= 5)
            {
                wizertLocationX -= 1;
            }
            else
            {
                Console.WriteLine("There is no door that direction.");
            }
        }

        //method to return wizert location
        public (int, int) WizertLocation()
        {
            return (wizertLocationX, wizertLocationY);
        }

        //testing method to print out location
        public void PrintWizertLocation()
        {
            Console.WriteLine($"{wizertLocationX}, {wizertLocationY}"); 
        }

        public void ReceivePowerup(int points)
        {
            if(points == 10)
            {
                healthPoints = healthPoints + points;
            }
            else
            {
                magickaPoints = magickaPoints + points;
            }
            
        }

        public void PrintExitFoundMessage()
        {
            Console.WriteLine("\r\nThe door creaks open and the moonlight streaks through " +
                "the door. You stumble forward and fall to you knees." +
                " The cold air stings your lungs. Quickly getting up, " +
                "you run into the trees and leave that wretched dungeon behind.");
        }
    }
}
