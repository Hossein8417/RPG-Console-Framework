using System;
using System.Threading;
public enum Flow { 
    Start,
	MainMenu,
    CharacterSelect,
    Battle,
    Quit
}
//all of thread.sleep() lines must delete and use correct method for it
//code must refactored and must use SOLID and Design pattenrs(when possible)
//quest system must add to app 
//shop system must add to app
//skills must affect on damages and heals

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
        }
    }
    public static void AppStart() {
        Console.WriteLine("Loading app,Please wait!");
        //Thread.Sleep(1700);
        //Console.Clear();
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
        {   //charcaters must give damage with item1 and defend and heal with item2
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[0]);
            inventory.playerInventory.Add(ItemsList.items[4]);
        }
        else if (CharacterList.userChoose == "2")
        {
            inventory.playerInventory.Clear();
            inventory.playerInventory.Add(ItemsList.items[1]);
            inventory.playerInventory.Add(ItemsList.items[5]);
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
            inventory.playerInventory.Add(ItemsList.items[5]);
        }
        else Console.WriteLine("Select a valid character!");

        CurrentFlow = Flow.Battle;
    }
    public static void Battle()
    {
        Console.WriteLine($"{CharacterList.PlayerCharacter.Name} vs {CharacterList.AI.Name}");

        inventory.ShowPlayerInventory();
        inventory.ShowAiInventory();

        for (int round = 1; round <= 6; round++)
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

            //if (CharacterList.AI.Health != 0 || CharacterList.PlayerCharacter.Health !=0)
            //{
            //    Console.WriteLine("Tie");
            //}

            if (round == 1 || round == 3 || round == 5)//player attacks
            {  
                CharacterList.PlayerCharacter.Attack(CharacterList.PlayerCharacter, CharacterList.AI);
                CharacterList.AI.Defend(CharacterList.AI, CharacterList.PlayerCharacter);
                CharacterList.AI.Health -= CharacterList.PlayerCharacter.Item.Damage;
            }

            else if (round == 2 || round == 4 || round == 6)//ai attacks
            {
                CharacterList.AI.Attack(CharacterList.AI, CharacterList.PlayerCharacter);
                CharacterList.PlayerCharacter.Defend(CharacterList.PlayerCharacter, CharacterList.AI);
                CharacterList.PlayerCharacter.Health -= Character.Damage;
            }

            Thread.Sleep(1500);
            //Console.Clear();
        }
        ReLoopApp();
    }
    public static void ReLoopApp() {
        Console.WriteLine("Play again? (Y/N)");
        string userAction = Console.ReadLine().ToLower().Trim();
        char appLoopStart;
        bool isValid = char.TryParse(userAction, out appLoopStart);
        if (isValid)
        {
            if (appLoopStart == 'y')
            {
                CurrentFlow = Flow.CharacterSelect;
                
            }
            if (appLoopStart == 'n')
            {
                CurrentFlow = Flow.Quit;
            }
        }
        else Console.WriteLine("Try String form of input");
    }
    public static void Quit()
    {
        Console.Clear();
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
        Program.AppLoop = false;
    }
}