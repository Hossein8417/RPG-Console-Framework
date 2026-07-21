class CharacterSelectState 
{
    public static void CharactersSelect()
    {
        AppInterface.PlayerCharacterSelect();

        Player.GetCharacter();

        AI.SetCharacter();

        CurrentFlow.CurrentState = Flow.Battle;
    }

}