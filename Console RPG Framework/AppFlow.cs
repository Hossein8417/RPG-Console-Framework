using System;
using System.Threading;
public enum Flow { 
    Start,
	MainMenu,
    CharacterSelect,
    Battle,
    Quit
}
//ai can take player character need to fix

class AppFlow { 

    static Flow CurrentFlow = Flow.Start;

    public static bool mainMenuLoop = true;

    public static string userChoose;
    public static void SectionSwitcher() {

        switch (CurrentFlow)
        {
            case Flow.Start:
                AppStart();
                CurrentFlow = Flow.MainMenu;
                break;

            case Flow.MainMenu:
                MainMenu();
                break;

            case Flow.CharacterSelect:
                CharacterSelect();
                CurrentFlow = Flow.Battle;
                break;

            case Flow.Battle:
                Battle(CharacterList.PlayerCharacter, CharacterList.AiCharacter);
                //CurrentFlow = Flow.Start;
                break;

            case Flow.Quit:
                Quit();
                break;

            default:
                Console.WriteLine("Invalid phase");
                break;
        }
    }
    public static void AppStart() {
        Console.WriteLine("Loading app");
    }
    public static void MainMenu() {

        Console.WriteLine("Hello and welcome to this RPG Framework that built for console");
        while (mainMenuLoop)
        {
            Console.WriteLine("1_Play\n2_Quit Game");
            string input = Console.ReadLine().ToLower().Trim();
            while (true)
            {
                if (input == "play" || input == "1")
                {
                    CurrentFlow = Flow.CharacterSelect;
                    break;
                }
                else if (input == "quit" || input == "2")
                {
                    CurrentFlow = Flow.Quit;
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
    public static void CharacterSelect()
    {
        Console.WriteLine("Select Character:\nWitcher\nAssassin\nIron Heart\nWitch\nNether Blade\nAsh");
        userChoose = Console.ReadLine().ToLower().Trim();
        // i create a obj for player and i use obj's name and properties and .... that is not correct and need to fix 
        //solution: player must create from user choice and read user choice's player's name and properties
        CharacterList.PlayerCharacter.IsSelectable = false;

        foreach (Character character in CharacterList.characters)
        {
            if (character.IsSelectable == true)
            {
                CharacterList.freeCharacters.Add(character);
            }
        }

        if (userChoose == "assassin")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[0]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (userChoose == "witcher")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[1]);
            inventory.playerInventory.Add(ItemsList.items[2]);
        }
        else if (userChoose == "ironheart")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[3]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (userChoose == "witch")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[0]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (userChoose == "netherblade")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[3]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (userChoose == "ash")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[1]);
            inventory.playerInventory.Add(ItemsList.items[2]);
        }
        else Console.WriteLine("Select a valid character!");
    }
    public static void Battle(Player player, Character ai)
    {
        
        CharacterList.PlayerCharacter.Name = userChoose;

        CharacterList.PlayerCharacter = player;

        CharacterList.AiCharacter = ai;
       

        Random random = new Random();
        int characterIndex = random.Next(0, CharacterList.freeCharacters.Count);
        ai = CharacterList.freeCharacters[characterIndex];

        Console.WriteLine($"{player.Name} vs {ai.Name}\n");
        inventory.ShowPlayerInventory();
        inventory.ShowAiInventory();

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
            //every character have different item in their inventory and every item have different skills that affect on final damage or health

            Thread.Sleep(1500);
            //Console.Clear();
            round++;
        }
    }
    public static void Quit()
    {
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
        mainMenuLoop = false;
    }
}