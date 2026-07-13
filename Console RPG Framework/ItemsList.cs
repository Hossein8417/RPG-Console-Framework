using System.Collections.Generic;

class ItemsList
{

    public static List<ItemsDataBase> items = new List<ItemsDataBase> {
        new Sword("Sword",200,0,8),
        new Bow("Bow & Arrow",150,0,12),
        new Arrow("Stick",11,0,9),
        new Axe("Axe", 500,0,30),
        new Sheild("Sheild",350,30,0),
        new IronArmor("IronArmor",1000,35,0),
        new GoldArmor("GoldArmor",2000,44,0),
        new HealthPotion("HealthPotion",400,100,0),
        new FastRunPotion("FastRunPotion",650,0,15)
    };
}