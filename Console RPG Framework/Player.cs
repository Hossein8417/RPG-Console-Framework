using System;

class Player {

    public static CharactersDataBase PlayerCharacter;

    public static void GetCharacter()
    {
        bool isValid = int.TryParse(AppInterface.userChoose, out AppInterface.userChooseIndex);
        while (true)
        {
            if (isValid)
            {
                SetCharacter();
                break;
            }
            else AppInterface.UserHelper();
        }
    }

    public static void SetCharacter()
    {

        PlayerCharacter = Characters.characters[AppInterface.userChooseIndex - 1];
        PlayerCharacter.IsSelectable = false;
    }

}