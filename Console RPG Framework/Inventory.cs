using System;
using System.Collections.Generic;

class inventory {

    public static List<Items> playerInventory = new List<Items>();
    public static List<Items> aiInventory = new List<Items>();


    public static void ShowPlayerInventory()
    {
        Console.WriteLine($"{CharacterList.Player.Name} inventory is:");
        int indexNumber = 1;
        foreach (Items item in playerInventory)
        {
            Console.WriteLine($"{indexNumber}_{item.Name}");
            indexNumber++;
        }
    }

    public static void ShowAiInventory()
    {
        Items item1 = CharacterList.AI.Item;
        Items item2 = CharacterList.AI.Item2;

        aiInventory.Clear();
        aiInventory.Add(item1);
        aiInventory.Add(item2);

        Console.WriteLine($"{CharacterList.AI.Name} inventory is:");
        int indexNumber = 1;

        Console.WriteLine($"{indexNumber}_{item1.Name}");
        Console.WriteLine($"{indexNumber + 1}_{item2.Name}");
    }
}