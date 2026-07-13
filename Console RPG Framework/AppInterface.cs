using System;

class AppInterface
{

    public static string userChoose;
    public static int userChooseIndex;

    public static void CharacterSelect()
    {
        Console.WriteLine("For next content please select character by number's (1-6) : ");
        Console.WriteLine($"Select Character:\n1-{CharactersDataBase.characters[0].Name}\n2-{CharactersDataBase.characters[1].Name}\n3-{CharactersDataBase.characters[2].Name}" +
            $"\n4-{CharactersDataBase.characters[3].Name}\n5-{CharactersDataBase.characters[4].Name}\n6-{CharactersDataBase.characters[5].Name}");
        userChoose = Console.ReadLine().Trim();

        
    }
}