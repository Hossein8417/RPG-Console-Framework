using System;
using System.Collections.Generic;
using System.Threading;
//ai can take player character meed to fix
//every character have different item in their inventory and every item have different skills that affect on final damage or health
class Program {
    public static bool firstMenuLoop = true;
    public static bool mainMenuLoop = true;
    public static string userChoose;

    public static Character AI;
    public static Player Player = new Player("", 100, true);

    
    
    public static List<Items> playerInventory = new List<Items>();

    //app manager(entery point)
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to this RPG Framework that built for console");
        while (mainMenuLoop)
        {
            Console.WriteLine("1_Play\n2_Quit Game");
            string input = Console.ReadLine().ToLower().Trim();
            while (true)
            {
                if (input == "play" || input == "1")
                {
                    GameManager();
                    break;
                }
                else if (input == "quit" || input == "2")
                {   
                    Quit();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                    break;
                }
            }            
        }      
    }
    //app flow
    public static void GameManager()
    {
        Console.WriteLine("Select Character:\nWitcher\nAssassin\nIron Heart\nWitch\nNether Blade\nAsh");
        userChoose = Console.ReadLine().ToLower().Trim();

        Player.IsSelectable = false;

        foreach (Character character in CharacterList.characters)
        {
            if (character.IsSelectable == true)
            {
                CharacterList.freeCharacters.Add(character);
            }
        }

        if (userChoose == "assassin")
        {
            playerInventory.Clear();
            playerInventory.Add(ItemsList.items[0]);
            playerInventory.Add(ItemsList.items[4]);
            Battle(Player, AI);
        }
        else if (userChoose == "witcher")
        {
            playerInventory.Clear();
            playerInventory.Add(ItemsList.items[1]);
            playerInventory.Add(ItemsList.items[2]);
            Battle(Player, AI);

        }
        else if (userChoose == "ironheart")
        {
            playerInventory.Clear();
            playerInventory.Add(ItemsList.items[3]);
            playerInventory.Add(ItemsList.items[4]);
            Battle(Player, AI);

        }
        else if (userChoose == "witch")
        {
            playerInventory.Clear();
            playerInventory.Add(ItemsList.items[0]);
            playerInventory.Add(ItemsList.items[4]);
            Battle(Player, AI);

        }
        else if (userChoose == "netherblade")
        {
            playerInventory.Clear();
            playerInventory.Add(ItemsList.items[3]);
            playerInventory.Add(ItemsList.items[4]);
            Battle(Player, AI);

        }
        else if (userChoose == "ash")
        {
            playerInventory.Clear();
            playerInventory.Add(ItemsList.items[1]);
            playerInventory.Add(ItemsList.items[2]);
            Battle(Player, AI);

        }
        else Console.WriteLine("Select a valid character!");
    }

    //app flow
    public static void Battle(Player player, Character ai)
    {
        Player.Name = userChoose;
        AI = ai;
        Player = player;

        Random random = new Random();
        int characterIndex = random.Next(0, CharacterList.freeCharacters.Count);
        ai = CharacterList.freeCharacters[characterIndex];

        Console.WriteLine($"{player.Name} vs {ai.Name}\n");
        ShowPlayerInventory();
        ShowAiInventory();

        for (int round = 1; round <= 6;)
        {
            Console.WriteLine($"Round {round}");

            if (player.Health <= 0)
            {
                Console.WriteLine("ai win");
            }

            if (ai.Health <= 0)
            {
                Console.WriteLine("player win");
            }

            if (round == 1 || round == 3 || round == 5)
            {
                player.Attack(player, ai);
                //ai.Health -= player.item.damage;
                ai.Defend(ai, player);
            }
            else if (round == 2 || round == 4 || round == 6)
            {
                ai.Attack(ai, player);
                //player.Health -= ai.item.damage;
                player.Defend(player, ai);
            }


            //+- player item level skill,+- ai item level skill
            //+- ai item level skill ,+- player item level skill

            Thread.Sleep(1500);
            //Console.Clear();
            round++;
        }
    }
    //inventory
    public static void ShowPlayerInventory()
    {
        Console.WriteLine("your inventory is:");
        int indexNumber = 1;
        foreach (Items item in playerInventory)
        {
            Console.WriteLine($"{indexNumber}_{item.Name}");
            indexNumber++;
        }
    }
    //inventory
    public static void ShowAiInventory(){
        string item = AI.Item.Name;
        string item2= AI.Item2.Name;

        Console.WriteLine($"{AI} inventory is:");
        
        for (int indexNumber = 1; indexNumber <= 4; indexNumber++)
        {
            Console.WriteLine($"{indexNumber}_{item}");
            Console.WriteLine($"{indexNumber}_{item2}");
            Console.WriteLine();
        }
    }
    //app flow
    public static  void Quit() {
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
        mainMenuLoop = false;
    }
}