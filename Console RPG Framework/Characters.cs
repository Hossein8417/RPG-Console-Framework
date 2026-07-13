using System.Collections.Generic;

class Characters
{

    public static List<CharactersDataBase> characters = new List<CharactersDataBase> {
        new Witcher("Witcher",100, true, 3, Items.items[1], Items.items[4]),
        new Assassin("Assassin",100, true, 2, Items.items[0], Items.items[5]),
        new IronHeart("Iron Heart",100, true, 5, Items.items[3], Items.items[4]),
        new Witch("Witch", 100, true, 4, Items.items[0], Items.items[5]),
        new NetherBlade("Nether Blade", 100, true, 6, Items.items[3], Items.items[4]),
        new Ash("Ash", 100, true, 2, Items.items[1], Items.items[5])
    };

    public static List<CharactersDataBase> freeCharacters = new List<CharactersDataBase>();
    

}