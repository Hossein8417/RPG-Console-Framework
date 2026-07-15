class CharacterSelectState
{
    public static void CharactersSelect()
    {
        AppInterface.CharacterSelect();
        
        Player.GetCharacter();

        AI.SetCharacter();

        CurrentFlow.CurrentState = Flow.Battle;
    }
}