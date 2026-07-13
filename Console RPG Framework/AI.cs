class AI {
    public static CharactersDataBase AiCharacter;

    public static void GetCharacter()
    {
        foreach (CharactersDataBase character in Characters.characters)
        {
            if (character.IsSelectable == true)
            {
                Characters.freeCharacters.Add(character);
            }
        }
    }

    public static void SetCharacter()
    {
        GetCharacter();

        AiCharacter = Characters.freeCharacters[GenerateRandomIndex.aiCharaceterIndex];

    }
}