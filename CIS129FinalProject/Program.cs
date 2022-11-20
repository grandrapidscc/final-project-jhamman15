//create 2d array for the game map 5x5
using CIS129FinalProject;
using System.Diagnostics;

int[,] dungeonArrayMap = new int[5, 5];

//create a new wizert and enemies at the start
Wizert wizert = new Wizert(100,200);

//create a list enemies
List<Enemy> enemies = new List<Enemy>();

enemies.Add(new Enemy("Goblin", 3, 2, 2, 1));
enemies.Add(new Enemy("Goblin", 3, 2, 4, 2));




/*List<(int, int)> enemyLocations = new List<(int, int)>();
enemyLocations.Add(goblinOne.EnemyLocation());
enemyLocations.Add(goblinTwo.EnemyLocation());*/

//location of exit
(int,int) ExitLocation = (6, 6);

bool run = true;

while (run)
{
    //have wizert move through map with prompts from user
    Console.WriteLine("You are in a room, press...\r\n" +
                        "1. To go north\r\n" +
                        "2. To go south\r\n" +
                        "3. To go east\r\n" +
                        "4. To go west");

    var input = Console.ReadLine();
    
    switch (input)
    {
        case "1":
            Console.WriteLine("Go North");
            wizert.MoveNorth();
            //check if wizert location is equal to exit location
            if (wizert.WizertLocation() == ExitLocation)
            {
                Console.WriteLine("You have found the exit.");
                run = false;
                break;
            }

            Console.WriteLine("Wizert Location:" + wizert.WizertLocation());

            
            //check if wizert in enemy location
            Enemy enemy = enemies.FirstOrDefault(x => x.locationX == wizert.wizertLocationX 
                                                    && x.locationY == wizert.wizertLocationY);

            
            //if enemy is not null, intitate a battle
            if (enemy != null)
            {
                //bool for battle loop
                bool battle = true;

                    Console.WriteLine($"You have encountered a {enemy.enemyName}.\r\n" +
                    $"Its current HP is {enemy.GetEnemyHealth()}. " +
                    "Press...\r\n" +
                    "1.To Attack\r\n" +
                    "2.To Heal\r\n" +
                    "3.To Attempt to Flee\r\n");
                //List wizert health and magicka after each round
                Console.WriteLine("Wizert Health: " + wizert.GetCurrentHealth());
                Console.WriteLine("Wizert Magicka: " + wizert.GetMagickaPoints());

                var choice = Console.ReadLine();
                //swicth statement for battles
                switch (choice)
                {
                    case "1":
                        //wizert attacks for 5, if enemy is still alive, enemy attacks at end of case
                        Console.WriteLine("Prior to Attack Enemy Health: " + enemy.GetEnemyHealth());
                        Console.WriteLine("You attack");

                        //wizert attack
                        wizert.UseFireBall();
                        //enemy taking damage - always 5
                        enemy.TakeDamage();

                        //check if enemy is killed
                        if(enemy.GetEnemyHealth() <= 0)
                        {
                            //remove enemy from list
                            enemies.Remove(enemy);
                            Console.WriteLine("Enemy Destroyed!");
                            Console.WriteLine("Wizert Health: " + wizert.GetCurrentHealth());
                            Console.WriteLine("Wizert Magicka: " + wizert.GetMagickaPoints());
                            battle = false;
                            break;
                        }

                        Console.WriteLine("Enemy Health: " + enemy.GetEnemyHealth());
                        Console.WriteLine("Wizert Health: " + wizert.GetCurrentHealth());
                        Console.WriteLine("Wizert Magicka: " + wizert.GetMagickaPoints());

                        //enemy attack ifenemy is alive
                        wizert.TakeDamage(enemy.EnemyAttack());
                        //check if wizert is killed
                        if (wizert.GetCurrentHealth() <= 0)
                        {
                            Console.WriteLine("The Wizert has been mortally wounded. Game Over");
                            battle = false;
                            run = false;
                            break;
                        }
                        Console.WriteLine("After Enemy Attack Wizert Health: " + wizert.GetCurrentHealth());
                        break;

                    case "2":
                        Console.WriteLine("Wizert Health Prior to Heal: " + wizert.GetCurrentHealth());
                        Console.WriteLine("You heal");
                        //wizert heals for 3
                        wizert.Heal();

                        Console.WriteLine("Wizert Health After Heal: " + wizert.GetCurrentHealth());
                        //wizert is attacked after heal
                        wizert.TakeDamage(enemy.EnemyAttack());
                        //check if wizert is killed
                        if (wizert.GetCurrentHealth() <= 0)
                        {
                            Console.WriteLine("The Wizert has been mortally wounded. Game Over");
                            battle = false;
                            run = false;
                            break;
                        }
                        Console.WriteLine("After Enemy Attack Wizert Health: " + wizert.GetCurrentHealth());

                        break;

                    case "3":
                        Console.WriteLine("You attempt to flee");
                        break;
                }

            }

            //breaks out of main switch statement
            break;

        case "2":
            Console.WriteLine("Go South");
            wizert.MoveSouth();
            if (wizert.WizertLocation() == ExitLocation)
            {
                Console.WriteLine("YOu have found the exit.");
                run = false;
            }
            
            wizert.PrintWizertLocation();
            break;

        case "3":
            Console.WriteLine("Go East");
            wizert.MoveEast();
            if (wizert.WizertLocation() == ExitLocation)
            {
                Console.WriteLine("YOu have found the exit.");
                run = false;
            }
            
            wizert.PrintWizertLocation();
            break;

        case "4":
            Console.WriteLine("Go West");
            wizert.MoveWest();
            if (wizert.WizertLocation() == ExitLocation)
            {
                Console.WriteLine("YOu have found the exit.");
                run = false;
            }
            
            wizert.PrintWizertLocation();
            break;
    }
}

