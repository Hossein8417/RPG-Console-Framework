using System;
using System.Collections.Generic;

class inventory {

    public static List<Items> playerInventory = new List<Items>();
    //public static List<Items> aiInventory = new List<Items>();


    public static void ShowPlayerInventory()
    {
        Console.WriteLine($"{CharacterList.PlayerCharacter.Name} inventory is:");
        int indexNumber = 1;
        foreach (Items item in playerInventory)
        {
            Console.WriteLine($"{indexNumber}_{item.Name}");
            indexNumber++;
        }
    }

    public static void ShowAiInventory()
    {
        Items item = CharacterList.AI.Item;
        Items item2 = CharacterList.AI.Item2;

        Console.WriteLine($"{CharacterList.AI.Name} inventory is:");
        
        for (int indexNumber = 1; indexNumber <= 2; indexNumber++)
        {
            Console.WriteLine($"{indexNumber}_{item.Name}");
            Console.WriteLine($"{indexNumber}_{item2.Name}");
            Console.WriteLine();
        }
    }
}