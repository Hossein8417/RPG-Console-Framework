using System;
class Inventory {
    public static void ShowCharacterInventory(CharactersDataBase character)
    {
        Console.WriteLine($"{character.Name} inventory is:");

        Console.WriteLine($"1_{character.Item.Name}");
        Console.WriteLine($"2_{character.Item2.Name}");
    }
}