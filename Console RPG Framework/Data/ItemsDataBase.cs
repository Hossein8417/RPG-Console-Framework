class ItemsDataBase
{
    public string Name { get;  set; }
    public int Price { get;  set; }
    public int Heal { get;  set; }
    public int ItemDamage { get;  set; }
    public ItemsDataBase(string name, int price, int heal, int damage)
    {
        Name = name;
        Price = price;
        Heal = heal;
        ItemDamage = damage;
    }

}
#region Items
class Sword : ItemsDataBase
{
    public Sword(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Bow : ItemsDataBase
{
    public Bow(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Arrow : ItemsDataBase
{
    public Arrow(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Axe : ItemsDataBase
{
    public Axe(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class Sheild : ItemsDataBase
{
    public Sheild(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class IronArmor : ItemsDataBase
{
    public IronArmor(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class GoldArmor : ItemsDataBase
{
    public GoldArmor(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class HealthPotion : ItemsDataBase
{
    public HealthPotion(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
class FastRunPotion : ItemsDataBase
{
    public FastRunPotion(string name, int price, int heal, int damage) : base(name, price, heal, damage) { }
}
#endregion 