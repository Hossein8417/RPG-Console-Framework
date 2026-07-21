using System;
class AppInterface
{
    #region AppMenu
    public static void LoadingDisplayer() {
        Console.WriteLine("Loading app,Please wait!");
    }
    #endregion


    #region Main menu
    public static void WelcomeDisplayer() {
        Console.WriteLine("Hello and welcome to this RPG Framework that built for console version 2.4");
    }
    public static void PlayMenuDisplayer(GameData data) {
        Console.WriteLine("1_Play\n2_Quit Game");
        data.UserInput.input = Console.ReadLine().ToLower().Trim();

    }

    #endregion


    #region Character Select

    public static void CharacterSelect(GameData data)
    {
        Console.WriteLine("For next content please select character by number's (1-6) : ");
        Console.WriteLine($"Select Character:\n1-{Characters.characters[0].Name}\n2-{Characters.characters[1].Name}\n3-{Characters.characters[2].Name}" +
            $"\n4-{Characters.characters[3].Name}\n5-{Characters.characters[4].Name}\n6-{Characters.characters[5].Name}");
        data.UserInput.userChoose = Console.ReadLine().Trim();        
    }
    #endregion


    #region Battle
    public static void BattleInfoDisplayer(GameData data) {
        Console.WriteLine($"{data.Player.PlayerCharacter.Name} vs {data.Ai.AiCharacter.Name}");
    }

    public static void RoundCountDisplayer(int round) {
        Console.WriteLine($"Round {round}");
    }

    public static void HealthDisplayer(CharactersDataBase character) {
        character.CalculateHealth();
        Console.WriteLine($"{character.Name} health before start match is : {character.health}");
    }
    public static void HealthUpdateDisplayer(CharactersDataBase character) {
        Console.WriteLine($"{character.Name} health is : {character.health}");
    }

    #endregion


    #region Quit
    //Quit state

    public static void GoodbyeDisplayer() {
        Console.WriteLine("GoodBye!");
        Console.WriteLine("Press any key to exit!");
    }

    #endregion


    #region Helpers

    public static void UserHelper() {
        Console.WriteLine("Please enter a valid option");
    }
    public static void PlayAgainMessage(GameData data) {
        Console.WriteLine("Play again? (Y/N)");
        data.UserInput.userAction = Console.ReadLine().ToLower().Trim();
    }
    #endregion
}