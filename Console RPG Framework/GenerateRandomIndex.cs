using System;

class GenerateRandomIndex
{

    public static Random random = new Random();
    public static int aiCharaceterIndex = random.Next(0, CharactersDataBase.freeCharacters.Count);
}