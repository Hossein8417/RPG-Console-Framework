using System;
class Program {

    public static void Main(string[] args)
    {
        AppFlow.SectionSwitcher();
    }







    //inventory
    public static void ShowPlayerInventory()
    {
        Console.WriteLine("your inventory is:");
        int indexNumber = 1;
        foreach (Items item in playerInventory)
        {
            Console.WriteLine($"{indexNumber}_{item.Name}");
            indexNumber++;
        }
    }
    //inventory
    public static void ShowAiInventory(){
        string item = CharacterList.AiCharacter.Item.Name;
        string item2= CharacterList.AiCharacter.Item2.Name;

        Console.WriteLine($"{CharacterList.AiCharacter} inventory is:");
        
        for (int indexNumber = 1; indexNumber <= 4; indexNumber++)
        {
            Console.WriteLine($"{indexNumber}_{item}");
            Console.WriteLine($"{indexNumber}_{item2}");
            Console.WriteLine();
        }
    }

    public static List<Items> playerInventory = new List<Items>();

}