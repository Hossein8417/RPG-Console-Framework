class StateMachine {
    
    public static void Machine() {        

        switch (CurrentFlow.CurrentState)
        {
            case Flow.Start:
                AppStartState.AppStart();
                break;

            case Flow.MainMenu:
                MainMenuState.MainMenu();
                break;

            case Flow.CharacterSelect:
                CharacterSelectState.CharactersSelect();
                break;

            case Flow.Battle:
                BattleState.Battle();
                break;

            case Flow.Quit:
                QuitState.Quit();
                break;
        }
    }
}