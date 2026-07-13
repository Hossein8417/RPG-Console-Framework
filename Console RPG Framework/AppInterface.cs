using System;

class AppInterface
{

    public static string userChoose;
    public static int userChooseIndex;

    public static void CharacterSelect()
    {
        Console.WriteLine("For next content please select character by number's (1-6) : ");
        Console.WriteLine($"Select Character:\n1-{Characters.characters[0].Name}\n2-{Characters.characters[1].Name}\n3-{Characters.characters[2].Name}" +
            $"\n4-{Characters.characters[3].Name}\n5-{Characters.characters[4].Name}\n6-{Characters.characters[5].Name}");
        userChoose = Console.ReadLine().Trim();

        
    }

    public static void HealthDisplayer(CharactersDataBase character) {
        character.CalculateHealth(character);
        Console.WriteLine($"{character.Name} health before start match is : {character.health}");
    }
    public static void HealthUpdateDisplayer(CharactersDataBase character) {
        Console.WriteLine($"{character.Name} health is : {character.health}");
    }
} 