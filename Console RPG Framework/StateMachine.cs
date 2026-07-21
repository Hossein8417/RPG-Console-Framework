using System.Collections.Generic;

interface IState
{
    void Run(GameData data);
}

class StateMachine {

    
    public Dictionary<Flow, IState> states = new Dictionary<Flow, IState>
    {
        { Flow.Start, new AppStartState() },
        { Flow.MainMenu, new MainMenuState() },
        { Flow.CharacterSelect, new CharacterSelectState() },
        { Flow.Battle, new BattleState() },
        { Flow.Quit, new QuitState() }
    };

    public void Machine(GameData data) { 
        states[data.CurrentFlow.CurrentState].Run(data);
    }
}