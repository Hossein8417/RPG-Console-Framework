class Items
{
    public string Name { get;  set; }
    public int Price { get;  set; }
    public int Heal { get;  set; }
    public int ItemDamage { get;  set; }
    public Items(string name, int price, int heal, int damage)
    {
        Name = name;
        Price = price;
        Heal = heal;
        ItemDamage = damage;
    }

}
#region Items
class Sword : Items
{
    public Sword(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Bow : Items
{
    public Bow(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Arrow : Items
{
    public Arrow(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Axe : Items
{
    public Axe(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Sheild : Items
{
    public Sheild(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class IronArmor : Items
{
    public IronArmor(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class GoldArmor : Items
{
    public GoldArmor(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class HealthPotion : Items
{
    public HealthPotion(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class FastRunPotion : Items
{
    public FastRunPotion(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
#endregion 