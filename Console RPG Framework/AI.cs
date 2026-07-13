class AI {
    public static Character AiCharacter;

    public static void GetCharacter()
    {
        foreach (Character character in CharactersDataBase.characters)
        {
            if (character.IsSelectable == true)
            {
                CharactersDataBase.freeCharacters.Add(character);
            }
        }
    }

    public static void SetCharacter()
    {
        GetCharacter();

        AiCharacter = CharactersDataBase.freeCharacters[GenerateRandomIndex.aiCharaceterIndex];
    }
}