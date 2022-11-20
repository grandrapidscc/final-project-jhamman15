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
        private int _healthPoints;
        private int _magickaPoints;

        public Wizert(int healthPoints, int magickaPoints)
        {
            _healthPoints = healthPoints;
            _magickaPoints = magickaPoints;
        }

        //action methods
        public void UseFireBall()
        {
            if( _magickaPoints > 0)
            {
                _magickaPoints = _magickaPoints - 3;
            }
            else
            {
                Console.WriteLine("Not enough Magicka Points");
            }
            
        }

        //method to return magicka points
        public int GetMagickaPoints()
        {
            return _magickaPoints;
        }

        //method to take damage depending on attack
        public void TakeDamage(int attackValue)
        {
            _healthPoints = _healthPoints - attackValue;
        }

        //method to get current health
        public int GetCurrentHealth()
        {
            return _healthPoints;
        }

        //method to heal and take away magicka
        public void Heal()
        {
            if(_magickaPoints > 5)
            {
                _healthPoints = _healthPoints + 3;
                _magickaPoints = _magickaPoints - 5;
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

/*        public int[,] WizertLocation()
        {
            return { wizertLocationX, wizertLocationY};
        }*/

        //testing method to print out location
        public void PrintWizertLocation()
        {
            Console.WriteLine($"{wizertLocationX}, {wizertLocationY}"); 
        }

    }
}
