using System;
using System.Collections.Generic;
interface IAbillity
{
    void Attack(Character player, Player ai);
    void Defend(Character player, Player ai);
}
class CharacterList {
    public static List<Character> characters = new List<Character> {
        new Witcher("Witcher",100, true,ItemsList.items[1], ItemsList.items[2]),
        new Assassin("Assassin",100, true, ItemsList.items[0], ItemsList.items[4]),
        new IronHeart("Iron Heart",100, true, ItemsList.items[3], ItemsList.items[4]),
        new Witch("Witch", 100, true, ItemsList.items[0], ItemsList.items[4]),
        new NetherBlade("Nether Blade", 100, true, ItemsList.items[3], ItemsList.items[4]),
        new Ash("Ash", 100, true, ItemsList.items[1], ItemsList.items[2])
    };
    public static List<Character> freeCharacters = new List<Character>();

    public static Character AiCharacter;
    //this player object must go to characters list and set bool to false and after that need another logic to avoid ai choose player character
    public static Player PlayerCharacter = new Player("", 100, true);

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
    public virtual void Attack(Character character1, Player character2)
    {
        Console.WriteLine($"{character1.Name} attacked {character2.Name}");
    }
    public virtual void Defend(Character character1, Player character2)
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