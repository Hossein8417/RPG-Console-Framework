class StateMachine {
    
    public static void Machine() {        

        switch (CurrentFlow.CurrentState)
        {
            case Flow.Start:
                AppStart();
                break;

            case Flow.MainMenu:
                MainMenu();
                break;

            case Flow.CharacterSelect:
                CharactersSelect();
                break;

            case Flow.Battle:
                Battle();
                break;

            case Flow.Quit:
                Quit();
                break;
        }
    }
}