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

        public int GetMagickaPoints()
        {
            return _magickaPoints;
        }

        public void TakeDamage()//add type of attack going in here 
        {
            _healthPoints--;
        }

        public int GetCurrentHealth()
        {
            return _healthPoints;
        }

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
        int wizertLocationX;
        int wizertLocationY;

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
            if (wizertLocationX > 0 && wizertLocationX <= 5)
            {
                wizertLocationX -= 1;
            }
            else
            {
                Console.WriteLine("There is no door that direction.");
            }
        }

        public void MoveWest()
        {
            if (wizertLocationY >= 0 && wizertLocationY < 5)
            {
                wizertLocationX += 1;
            }
            else
            {
                Console.WriteLine("There is no door that direction.");
            }
        }

        public (int, int) WizertLocation()
        {
            return (wizertLocationX, wizertLocationY);
        }

/*        public int[,] WizertLocation()
        {
            return { wizertLocationX, wizertLocationY};
        }*/

        public void PrintWizertLocation()
        {
            Console.WriteLine($"{wizertLocationX}, {wizertLocationY}"); 
        }

    }
}
