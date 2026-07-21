class AI : ICharacter{
    public CharactersDataBase AiCharacter;

    public void GetCharacter(GameData data)
    {
        foreach (CharactersDataBase character in Characters.characters)
        {
            if (character.IsSelectable == true)
            {
                data.Characters.freeCharacters.Add(character);
            }
        }
    }

    public void SetCharacter(GameData data)
    {
        GetCharacter(data);
        int index = GenerateRandomIndex.RandomIndex(data);
        AiCharacter = data.Characters.freeCharacters[index];

    }
}