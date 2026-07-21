using System.Threading.Tasks;

class CharacterSelectState : IState
{
    public void Run(GameData data)
    {
        data.Characters.CleanFreeCharactersList();

        AppInterface.CharacterSelect(data);

        data.Player.GetCharacter(data);
        
        data.Ai.SetCharacter(data);

        data.CurrentFlow.CurrentState = Flow.Battle;

    }
}