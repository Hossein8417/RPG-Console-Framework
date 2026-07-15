using System;

interface IAbillity
{
    void Attack(CharactersDataBase player, CharactersDataBase ai);
    void Defend(CharactersDataBase player, CharactersDataBase ai);
}

class CharactersDataBase : IAbillity
{
    public string Name { get; set; }
    public int BaseHealth { get;  set; }
    public int BaseDamage { get; set; }
    public bool IsSelectable { get;  set; }
    public ItemsDataBase Item { get; set; }
    public ItemsDataBase Item2 { get; set; }

    public int health;
    public int damage;
    public CharactersDataBase(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase items2)
    {
        Name = name;
        BaseHealth = baseHealth;
        BaseDamage = baseDamage;
        IsSelectable = isSelectable;
        Item = item;
        Item2 = items2;

    }
    public void Attack(CharactersDataBase character1, CharactersDataBase character2)
    {
        Console.WriteLine($"{character1.Name} attack {character2.Name}");

    }

    public void Defend(CharactersDataBase character1, CharactersDataBase character2)
    {
        Console.WriteLine($"{character1.Name} Defending himself from {character2.Name}");

        UpdateHealth(character1, character2);

    }

    public void CalculateHealth(CharactersDataBase character) {
        health = character.BaseHealth + character.Item2.Heal;
    }
    
    public void CalculateDamage(CharactersDataBase character) { 
        damage = character.BaseDamage + character.Item.ItemDamage;
    }

    public void UpdateHealth(CharactersDataBase character1, CharactersDataBase character2) { 
        character1.health -= character2.damage;
    }
}
#region Characters
class Witcher : CharactersDataBase
{
    public Witcher(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class Assassin : CharactersDataBase
{
    public Assassin(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class IronHeart : CharactersDataBase
{
    public IronHeart(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class Witch : CharactersDataBase
{
    public Witch(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class NetherBlade : CharactersDataBase
{
    public NetherBlade(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class Ash : CharactersDataBase
{
    public Ash(string name, int baseHealth, bool isSelectable, int baseDamage, ItemsDataBase item, ItemsDataBase item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
#endregion