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
        
        Player = characters[userChooseIndex - 1];
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
        
        int aiCharaceterIndex = random.Next(0, freeCharacters.Count);
        AI = freeCharacters[aiCharaceterIndex];
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