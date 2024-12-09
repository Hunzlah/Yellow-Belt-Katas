// See https://aka.ms/new-console-template for more information

using Yellow_Belt_Katas;

// Get valid player name
Console.WriteLine("Enter your name");
string playerName;
while (true)
{
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Enter valid name");
        continue;
    }
    
    playerName = input;
    break;
}

string[] enemyNames = new string[] { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" }; 
Player player1 = new Player(playerName, 100, 25, 0, 20);

// Game on
while (!player1.IsDead())
{
    int randomEncounter = Utilities.GetRandomNumber(0, 3);
    switch ((EncounterType)randomEncounter)
    {
        case EncounterType.Enemy:
            Enemy enemy1 = new Enemy(enemyNames[Utilities.GetRandomNumber(0, enemyNames.Length)], 
                Utilities.GetRandomNumber(20, 31), Utilities.GetRandomNumber(15, 26));
            enemy1.Interact();
            while (!player1.IsDead() && !enemy1.IsDead())
            {
                int inputAction = Utilities.GetInputInRange(1, 2, new string[]{"Attack", "Heal"});
                switch ((ActionType)inputAction)
                {
                    case ActionType.Attack:
                        player1.Attack(enemy1);
                        break;
                    case ActionType.Heal:
                        player1.Heal(10);
                        break;
                }

                if (enemy1.IsDead())
                {
                    continue;
                }
                
                enemy1.Attack(player1);
                
            }
            break;
        case EncounterType.Npc:
            Npc npc1 = new Npc("Villager", "Welcome to our village!");
            npc1.Interact();
            break;
        case EncounterType.Merchant: 
            Merchant merchant1 = new Merchant("Merchant", "Take a look at my wares.", new List<string>(){"Sword", "Shield", "Potion"});
            merchant1.Interact();
            break;
        
    }
}

enum EncounterType
{
    Enemy, Npc, Merchant
}

enum  ActionType
{
    Attack = 1, Heal = 2
}


