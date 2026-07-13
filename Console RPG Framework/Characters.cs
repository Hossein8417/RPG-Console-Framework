using System;
using System.Collections.Generic;
//player => AI => characters => freeCharacters to dont get null ref

//logic must separate from app interface

// every method must do one think
//every class must have relevant content
// logic must call a interface and interface must contact appinterface
//app interface can directly call logic but opposite not!
interface IAbillity
{
    void Attack(Character player, Character ai);
    void Defend(Character player, Character ai);
}
class CharactersDataBase {

    public static Character Player;

    public static Character AI;

    public static List<Character> characters = new List<Character> {
        new Witcher("Witcher",100, true, 3, ItemsList.items[1], ItemsList.items[4]),
        new Assassin("Assassin",100, true, 2, ItemsList.items[0], ItemsList.items[5]),
        new IronHeart("Iron Heart",100, true, 5, ItemsList.items[3], ItemsList.items[4]),
        new Witch("Witch", 100, true, 4, ItemsList.items[0], ItemsList.items[5]),
        new NetherBlade("Nether Blade", 100, true, 6, ItemsList.items[3], ItemsList.items[4]),
        new Ash("Ash", 100, true, 2, ItemsList.items[1], ItemsList.items[5])
    };

    public static List<Character> freeCharacters = new List<Character>();
    
    public static void GetPlayerCharacter()
    {
        // this must change!
        AppInterface.CharacterSelect();

        bool isValid = int.TryParse(AppInterface.userChoose, out AppInterface.userChooseIndex);
        while (true)
        {

            if (isValid)
            {
                SetPlayerCharacter();
                break;
            }
            else Console.WriteLine("Enter a valid type!!");
        }
    }

    public static void SetPlayerCharacter() {
        
        Player = characters[AppInterface.userChooseIndex - 1];
        Player.IsSelectable = false;
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

        AI = freeCharacters[GenerateRandomIndex.aiCharaceterIndex];
    }    
}
class Character : IAbillity
{
    public string Name { get; set; }
    public int BaseHealth { get;  set; }
    public int BaseDamage { get; set; }
    public bool IsSelectable { get;  set; }
    public Items Item { get; set; }
    public Items Item2 { get; set; }

    int health;
    int damage;
    public Character(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items items2)
    {
        Name = name;
        BaseHealth = baseHealth;
        BaseDamage = baseDamage;
        IsSelectable = isSelectable;
        Item = item;
        Item2 = items2;

    }
    public void Attack(Character character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} attack {character2.Name}");

    }
    public void Defend(Character character1, Character character2)
    {
        Console.WriteLine($"{character1.Name} Defending himself from {character2.Name}");

        UpdateHealth(character1, character2);

    }
    public void CalculateHealth(Character character) {
        health = character.BaseHealth + character.Item2.Heal;
        Console.WriteLine($"{character.Name} health is {health}.(Before start game)");
    }
    
    public void CalculateDamage(Character character) { 
        damage = character.BaseDamage + character.Item.ItemDamage;
    }
    public void UpdateHealth(Character character1, Character character2) { 
        character1.health -= character2.damage;
        Console.WriteLine($"{character1.Name} health is {health}");
    }
}
#region Characters
class Witcher : Character
{
    public Witcher(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class Assassin : Character
{
    public Assassin(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class IronHeart : Character
{
    public IronHeart(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class Witch : Character
{
    public Witch(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class NetherBlade : Character
{
    public NetherBlade(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
class Ash : Character
{
    public Ash(string name, int baseHealth, bool isSelectable, int baseDamage, Items item, Items item2) : base(name, baseHealth, isSelectable, baseDamage, item, item2) { }
}
#endregion
