using System;

class GenerateRandomIndex
{

    public static Random random = new Random();

    public static int RandomIndex(GameData data) {
        return random.Next(0, data.Characters.freeCharacters.Count);
    } 
}