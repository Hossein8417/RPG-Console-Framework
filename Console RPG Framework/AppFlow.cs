using System;
using System.Threading;
public enum Flow { 
    Start,
	MainMenu,
    CharacterSelect,
    Battle,
    Quit
}

class AppFlow {
    public static bool loop = true;
    
    public static Flow CurrentFlow = Flow.Start;
    public static void SectionSwitcher() {

        switch (CurrentFlow)
        {
            case Flow.Start:
                AppStart();
                break;

            case Flow.MainMenu:
                MainMenu();
                break;

            case Flow.CharacterSelect:
                CharacterSelect();
                break;

            case Flow.Battle:
                Battle();
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
        CurrentFlow = Flow.MainMenu;
    }
    public static void MainMenu() {
        //loop #1
        Console.WriteLine("Hello and welcome to this RPG Framework that built for console");
        while (loop)
        {
            bool menuLoop = true;
            Console.WriteLine("1_Play\n2_Quit Game");
            string input = Console.ReadLine().ToLower().Trim();
            //loop #2
            while (menuLoop)
            {
                if (input == "play" || input == "1")
                {
                    CurrentFlow = Flow.CharacterSelect;
                    loop = false;
                    break;
                }
                else if (input == "quit" || input == "2")
                {
                    CurrentFlow = Flow.Quit;
                    loop = false;
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
        CharacterList.GetPlayerCharacter();

        CharacterList.SetAICharacter();

        if (CharacterList.userChoose == "1")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[0]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (CharacterList.userChoose == "2")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[1]);
            inventory.playerInventory.Add(ItemsList.items[2]);
        }
        else if (CharacterList.userChoose == "3")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[3]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (CharacterList.userChoose == "4")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[0]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (CharacterList.userChoose == "5")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[3]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (CharacterList.userChoose == "6")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[1]);
            inventory.playerInventory.Add(ItemsList.items[2]);
        }
        else Console.WriteLine("Select a valid character!");

        CurrentFlow = Flow.Battle;
    }
    public static void Battle()
    {
        //CharacterList.PlayerCharacter = player;
        //CharacterList.AI = ai;
        //player = CharacterList.PlayerCharacter;
        //ai = CharacterList.AI;

        Console.WriteLine($"{CharacterList.PlayerCharacter.Name} vs {CharacterList.AI.Name}");
        inventory.ShowPlayerInventory();
        inventory.ShowAiInventory();

        for (int round = 1; round <= 6;)
        {
            Console.WriteLine($"Round {round}");

            if (CharacterList.PlayerCharacter.Health <= 0)
            {
                Console.WriteLine("ai win");
            }

            if (CharacterList.AI.Health <= 0)
            {
                Console.WriteLine("player win");
            }

            if (round == 1 || round == 3 || round == 5)
            {
                CharacterList.PlayerCharacter.Attack(CharacterList.PlayerCharacter, CharacterList.AI);
                //ai.Health -= player.item.damage;
                CharacterList.AI.Defend(CharacterList.AI, CharacterList.PlayerCharacter);
            }
            else if (round == 2 || round == 4 || round == 6)
            {
                CharacterList.AI.Attack(CharacterList.AI, CharacterList.PlayerCharacter);
                //player.Health -= ai.item.damage;
                CharacterList.PlayerCharacter.Defend(CharacterList.PlayerCharacter, CharacterList.AI);
            }


            //+- player item level skill,+- ai item level skill
            //+- ai item level skill ,+- player item level skill
            //every character have different item in their inventory and every item have different skills that affect on final damage or health

            Thread.Sleep(1500);
            //Console.Clear();
            round++;
        }
        CurrentFlow = Flow.Start;
    }
    public static void Quit()
    {
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
        Program.AppLoop = false;
    }
}