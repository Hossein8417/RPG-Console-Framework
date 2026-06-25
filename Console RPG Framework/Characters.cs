using System;
interface IAbillity
{
    void Attack(Character player, Player ai);
    void Defend(Character player, Player ai);
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