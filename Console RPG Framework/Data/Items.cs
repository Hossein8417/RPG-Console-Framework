using System.Collections.Generic;

class Items
{

    public static List<ItemsDataBase> items = new List<ItemsDataBase> {
        new Sword("Sword",200,0,15),
        new Bow("Bow & Arrow",150,0,25),
        new Arrow("Stick",11,0,18),
        new Axe("Axe", 500,0,33),
        new Sheild("Sheild",350,30,0),
        new IronArmor("IronArmor",1000,35,0),
        new GoldArmor("GoldArmor",2000,44,0),
        new HealthPotion("HealthPotion",400,100,0),
        new FastRunPotion("FastRunPotion",650,0,20)
        //some of items doesn't exist in the game because i planed to add store feature to game and player can buy it from store but this store delet from the final version
        //so i decided to to leave this items here , maybe some i add this items to game 
    };
}