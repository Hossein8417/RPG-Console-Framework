using System;
using System.Xml.Serialization;

class AppInterface
{
    //Fields
    public static string userChoose;
    public static int userChooseIndex;
    public static string input;
    public static string userAction;


    //App start state
    public static void LoadingDisplayer() {
        Console.WriteLine("Loading app,Please wait!");
    }

    //Main menu state
    public static void WelcomeDisplayer() {
        Console.WriteLine("Hello and welcome to this RPG Framework that built for console");
    }
    public static void PlayMenuDisplayer() {
        Console.WriteLine("1_Play\n2_Quit Game");
        input = Console.ReadLine().ToLower().Trim();

    }
    // Character Select State
    public static void CharacterSelect()
    {
        Console.WriteLine("For next content please select character by number's (1-6) : ");
        Console.WriteLine($"Select Character:\n1-{Characters.characters[0].Name}\n2-{Characters.characters[1].Name}\n3-{Characters.characters[2].Name}" +
            $"\n4-{Characters.characters[3].Name}\n5-{Characters.characters[4].Name}\n6-{Characters.characters[5].Name}");
        userChoose = Console.ReadLine().Trim();        
    }
    //Battle State
    public static void BattleInfoDisplayer() {
        Console.WriteLine($"{Player.PlayerCharacter.Name} vs {AI.AiCharacter.Name}");
    }

    public static void RoundCountDisplayer(int round) {
        Console.WriteLine($"Round {round}");
    }

    public static void HealthDisplayer(CharactersDataBase character) {
        character.CalculateHealth(character);
        Console.WriteLine($"{character.Name} health before start match is : {character.health}");
    }
    public static void HealthUpdateDisplayer(CharactersDataBase character) {
        Console.WriteLine($"{character.Name} health is : {character.health}");
    }

    //Quit state

    public static void GoodbyeDisplayer() {
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
    }

    //Helpers

    public static void UserHelper() {
        Console.WriteLine("Please enter a valid option");
    }
    public static void PlayAgainMessage() {
        Console.WriteLine("Play again? (Y/N)");
        userAction = Console.ReadLine().ToLower().Trim();
    }

} 