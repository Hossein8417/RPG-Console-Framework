using System;

class Player {

    public static Character PlayerCharacter;

    public static void GetCharacter()
    {
        // this must change!
        AppInterface.CharacterSelect();

        bool isValid = int.TryParse(AppInterface.userChoose, out AppInterface.userChooseIndex);
        while (true)
        {

            if (isValid)
            {
                SetCharacter();
                break;
            }
            else Console.WriteLine("Enter a valid type!!");
        }
    }

    public static void SetCharacter()
    {

        PlayerCharacter = CharactersDataBase.characters[AppInterface.userChooseIndex - 1];
        PlayerCharacter.IsSelectable = false;
    }

}