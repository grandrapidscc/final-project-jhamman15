//create 2d array for the game map 5x5
using CIS129FinalProject;
using System.Diagnostics;

int[,] dungeonArrayMap = new int[5, 5];

//create a new wizert and enemies at the start
Wizert wizert = new Wizert(100,200);
Enemy goblinOne = new Enemy(5, 2, 3);
Enemy goblinTwo = new Enemy(5, 4, 3);


List<(int, int)> enemyLocations = new List<(int, int)>();
enemyLocations.Add(goblinOne.EnemyLocation());
enemyLocations.Add(goblinTwo.EnemyLocation());

//location of exit
(int,int) ExitLocation = (1, 1);

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

            Console.WriteLine("Wizert:" + wizert.WizertLocation());

            //if wizert location and enemy location are the same, initiate a fight
            foreach(var location in enemyLocations)
            {
                if (wizert.WizertLocation() == location)
                {
                    while (wizert.GetCurrentHealth() > 0 || goblinOne.GetGoblinHealth() > 0)
                    {
                        Console.WriteLine("Wizert Health: " + wizert.GetCurrentHealth());
                        Console.WriteLine("Wizert Magicka: " + wizert.GetMagickaPoints());
                        Console.WriteLine($"You have encountered a goblin.\r\n" +
                            $"Its current HP is {goblinOne.GetGoblinHealth()}." +
                            "Press...\r\n" +
                            "1.To Attack\r\n" +
                            "2.To Heal\r\n" +
                            "3.To Attempt to Flee\r\n");

                        var choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("You attack");
                                wizert.UseFireBall();
                                goblinOne.TakeDamage();
                                Console.WriteLine("Wizert Health: " + wizert.GetCurrentHealth());
                                Console.WriteLine("Wizert Magicka: " + wizert.GetMagickaPoints());
                                Console.WriteLine(goblinOne.GetGoblinHealth());
                                if (goblinOne.GetGoblinHealth() > 0)
                                {
                                    wizert.TakeDamage();
                                }
                                break;
                            case "2":
                                Console.WriteLine("You heal");
                                wizert.Heal();
                                Console.WriteLine(wizert.GetCurrentHealth());
                                Console.WriteLine("Wizert Magicka: " + wizert.GetMagickaPoints());
                                Console.WriteLine(goblinOne.GetGoblinHealth());
                                if (goblinOne.GetGoblinHealth() > 0)
                                {
                                    wizert.TakeDamage();
                                }
                                break;
                            case "3":
                                Console.WriteLine("You attempt to flee");
                                break;
                        }

                    }

                }
            }
            
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

