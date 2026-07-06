using System;
using System.Collections.Generic;
interface IAbillity
{
    void Attack(Character player, Character ai);
    void Defend(Character player, Character ai);
}
class CharacterList {


    public static string userChoose;
    public static int userChooseIndex;
    static Random random = new Random();

    public static Character PlayerCharacter;

    public static Character AI;

    public static List<Character> characters = new List<Character> {
        new Witcher("Witcher",100, true,ItemsList.items[1], ItemsList.items[2]),
        new Assassin("Assassin",100, true, ItemsList.items[0], ItemsList.items[4]),
        new IronHeart("Iron Heart",100, true, ItemsList.items[3], ItemsList.items[4]),
        new Witch("Witch", 100, true, ItemsList.items[0], ItemsList.items[4]),
        new NetherBlade("Nether Blade", 100, true, ItemsList.items[3], ItemsList.items[4]),
        new Ash("Ash", 100, true, ItemsList.items[1], ItemsList.items[2])
    };

    public static List<Character> freeCharacters = new List<Character>();
    
    public static void GetPlayerCharacter()
    {
        while (true) {
            Console.WriteLine("For next content please select character by number's (1-6) : ");
            Console.WriteLine($"Select Character:\n1-{characters[0].Name}\n2-{characters[1].Name}\n3-{characters[2].Name}" +
                $"\n4-{characters[3].Name}\n5-{characters[4].Name}\n6-{characters[5].Name}");
            userChoose = Console.ReadLine().Trim();

            bool isValid = int.TryParse(userChoose, out userChooseIndex);
            if (isValid)
            {
                SetPlayerCharacter();
                break;
            }
            else Console.WriteLine("Enter a valid type!!");
        }
    }

    public static void SetPlayerCharacter() {
        PlayerCharacter = characters[userChooseIndex - 1];
        PlayerCharacter.IsSelectable = false;
    }

    public static void GetAICharacter() {
        foreach (Character character in characters)
        {
            if (character.IsSelectable == true)
            {
                freeCharacters.Add(character);
            }
        }
    }

    public static void SetAICharacter()
    {
        GetAICharacter();
        
        int aiCharaceterIndex = random.Next(0, freeCharacters.Count);
        AI = freeCharacters[aiCharaceterIndex];
    }    
}
class Character : IAbillity
{
    public string Name { get; set; }
    public int Health { get;  set; }
    public bool IsSelectable { get;  set; }
    public Items Item { get; set; }
    public Items Item2 { get; set; }

    public Character(string name, int health, bool isSelectable, Items item, Items items2)
    {
        Name = name;
        Health = health;
        IsSelectable = isSelectable;
        Item = item;
        Item2 = items2;
    }
    public virtual void Attack(Character character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} attacked {character2.Name}");
    }
    public virtual void Defend(Character character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} defending himself from {character2.Name}");
    } 
}
#region Characters
class Player 
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool IsSelectable { get; set; }
    public Player(string name, int health, bool isSelectable) { 
        Name = name;
        Health = health;
        IsSelectable = isSelectable;
    }

    public void Attack(Player character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} attacked {character2.Name}");
    }
    public void Defend(Player character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} defending himself from {character2.Name}");
    }

}
class Witcher : Character
{
    public Witcher(string name, int health, bool isSelectable, Items item, Items item2) : base(name, health, isSelectable, item, item2) { }
}
class Assassin : Character
{
    public Assassin(string name, int health, bool isSelectable, Items item, Items item2) : base(name, health,isSelectable, item, item2) { }
}
class IronHeart : Character
{
    public IronHeart(string name, int health, bool isSelectable, Items item, Items item2) : base(name, health, isSelectable, item, item2) { }
}
class Witch : Character
{
    public Witch(string name, int health, bool isSelectable, Items item, Items item2) : base(name, health, isSelectable, item, item2) { }
}
class NetherBlade : Character
{
    public NetherBlade(string name, int health, bool isSelectable, Items item, Items item2) : base(name, health, isSelectable, item, item2) { }
}
class Ash : Character
{
    public Ash(string name, int health, bool isSelectable, Items item, Items item2) : base(name, health, isSelectable, item, item2) { }
}
#endregion