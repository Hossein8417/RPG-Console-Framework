using System;

class Player : ICharacter{

    public CharactersDataBase PlayerCharacter;

    public void GetCharacter(GameData data)
    {
        bool isValid = int.TryParse(data.UserInput.userChoose, out data.UserInput.userChooseIndex);
        while (true)
        {
            if (isValid)
            {
                SetCharacter(data);
                break;
            }
            else AppInterface.UserHelper();
        }
    }

    public void SetCharacter(GameData data)
    {
        PlayerCharacter = Characters.characters[data.UserInput.userChooseIndex - 1];
        PlayerCharacter.IsSelectable = false;
    }

}