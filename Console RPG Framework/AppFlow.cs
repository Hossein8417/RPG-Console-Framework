using System;
using System.Threading.Tasks;
public enum Flow { 
    Start,
	MainMenu,
    CharacterSelect,
    Battle,
    Quit
}
//code must refactored and must use SOLID and Design pattenrs(when possible)

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
                CharactersSelect();
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
        Delayer(3000);
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
    public static void CharactersSelect()
    {
        Player.SetCharacter();

        CharactersDataBase.SetAICharacter();
        
        CurrentFlow = Flow.Battle;
    }
    public static void Battle()
    {
        Console.WriteLine($"{Player.PlayerCharacter.Name} vs {CharactersDataBase.AI.Name}");

        Inventory.ShowCharacterInventory(Player.PlayerCharacter);
        Inventory.ShowCharacterInventory(CharactersDataBase.AI);

        AppInterface.HealthDisplayer(Player.PlayerCharacter);
        AppInterface.HealthDisplayer(CharactersDataBase.AI);

        Player.PlayerCharacter.CalculateDamage(Player.PlayerCharacter);
        CharactersDataBase.AI.CalculateDamage(CharactersDataBase.AI);

        for (int round = 1; round <= 6; round++)
        {
            Console.WriteLine($"Round {round}");

            AppInterface.HealthUpdateDisplayer(Player.PlayerCharacter);
            AppInterface.HealthUpdateDisplayer(CharactersDataBase.AI);

            if (round == 1 || round == 3 || round == 5)//player attacks
            {
                Player.PlayerCharacter.Attack(Player.PlayerCharacter, CharactersDataBase.AI);
                CharactersDataBase.AI.Defend(CharactersDataBase.AI, Player.PlayerCharacter);
            }

            else if (round == 2 || round == 4 || round == 6)//ai attacks
            {
                CharactersDataBase.AI.Attack(CharactersDataBase.AI, Player.PlayerCharacter);
                Player.PlayerCharacter.Defend(Player.PlayerCharacter,CharactersDataBase.AI);
            }

            Delayer(1500);
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
    async static void Delayer(int time) {
        await Task.Delay(time);
    }
    public static void Quit()
    {
        Console.Clear();
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
        Program.AppLoop = false;
    }
}