using System;

interface IAbillity
{
    void Attack();
    void Defend();
}
interface ICharacter
{
    void GetCharacter(GameData data);
    void SetCharacter(GameData data);
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
    public void Attack()
    {
        Console.WriteLine($"{this.Name} attacks !");

    }

    public void Defend()
    {
        Console.WriteLine($"{this.Name} Defending himself");

    }

    public void CalculateHealth() {
        health = this.BaseHealth + this.Item2.Heal;
    }
    
    public void CalculateDamage() { 
        damage = this.BaseDamage + this.Item.ItemDamage;
    }

    public void UpdateHealth(CharactersDataBase character) { 
        this.health -= character.damage;
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
